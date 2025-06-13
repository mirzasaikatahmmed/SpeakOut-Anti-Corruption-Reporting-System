using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System.Admin
{
    public partial class AssignInvestigatorForm : Form
    {
        private int reportId;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AssignInvestigatorForm()
        {
            InitializeComponent();
        }

        public AssignInvestigatorForm(int reportId)
        {
            InitializeComponent();
            this.reportId = reportId;
        }

        private void AssignInvestigatorForm_Load(object sender, EventArgs e)
        {
            LoadReportDetails();
            LoadInvestigators();
        }

        private void LoadReportDetails()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT Title, TypeOfCorruption, Location, Description, Date 
                                 FROM Reports WHERE ReportId = @ReportId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReportId", reportId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    reportID.Text = reportId.ToString();
                    dateOfSubmission.Text = Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy");
                    reportTitleTextBox.Text = dr["Title"].ToString();
                    typeOfCorruptionTextBox.Text = dr["TypeOfCorruption"].ToString();
                    locationTextBox.Text = dr["Location"].ToString();
                    reportDescriptionRichTextBox.Text = dr["Description"].ToString();
                }
                con.Close();
            }
        }

        private void LoadInvestigators()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT UserId, Name FROM Users WHERE Role = 'Investigator'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                investigatorsListComboBox.DataSource = dt;
                investigatorsListComboBox.DisplayMember = "Name";
                investigatorsListComboBox.ValueMember = "UserId";
                investigatorsListComboBox.SelectedIndex = -1;
            }
        }

        private void assignSubmitBTN_Click(object sender, EventArgs e)
        {
            if (investigatorsListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an investigator.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // 1. Insert into ReportAssignments
                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO ReportAssignments (ReportId, InvestigatorId) 
                                                       VALUES (@ReportId, @InvestigatorId)", con, transaction);
                    cmd1.Parameters.AddWithValue("@ReportId", reportId);
                    cmd1.Parameters.AddWithValue("@InvestigatorId", investigatorsListComboBox.SelectedValue);
                    cmd1.ExecuteNonQuery();

                    // 2. Update Reports status
                    SqlCommand cmd2 = new SqlCommand(@"UPDATE Reports SET Status = 'Assigned' 
                                                       WHERE ReportId = @ReportId", con, transaction);
                    cmd2.Parameters.AddWithValue("@ReportId", reportId);
                    cmd2.ExecuteNonQuery();

                    // 3. Optional: Log in ReportHistory
                    SqlCommand cmd3 = new SqlCommand(@"INSERT INTO ReportHistory (ReportId, Status, ChangedBy, Note, Timestamp)
                                                       VALUES (@ReportId, 'Assigned', @ChangedBy, @Note, GETDATE())", con, transaction);
                    cmd3.Parameters.AddWithValue("@ReportId", reportId);
                    cmd3.Parameters.AddWithValue("@ChangedBy", 1); // Admin UserId; change accordingly
                    cmd3.Parameters.AddWithValue("@Note", optionalNoteTextBox.Text.Trim());
                    cmd3.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Investigator assigned successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Assignment failed: " + ex.Message);
                }
            }
        }

        private void backPictureBoxBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back without assigning?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
