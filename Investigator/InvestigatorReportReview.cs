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

namespace SpeakOut___Anti_Corruption_Reporting_System.Investigator
{
    public partial class InvestigatorReportReview : Form
    {
        private int currentUserId;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public InvestigatorReportReview()
        {
            InitializeComponent();
        }

        public InvestigatorReportReview(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attachment viewer not implemented yet.");
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(reportIDtextBox.Text.Trim(), out int reportId))
            {
                LoadReportDetails(reportId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Report ID.");
            }
        }

        private void LoadReportDetails(int reportId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT r.ReportId, r.Title, r.TypeOfCorruption, r.Location, r.Description, r.Date, r.Status, 
                           ISNULL(u.Name, 'Anonymous') AS SubmittedBy
                    FROM Reports r
                    LEFT JOIN Users u ON r.SubmittedBy = u.UserId
                    INNER JOIN ReportAssignments ra ON r.ReportId = ra.ReportId
                    WHERE r.ReportId = @ReportId AND ra.InvestigatorId = @InvestigatorId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReportId", reportId);
                cmd.Parameters.AddWithValue("@InvestigatorId", currentUserId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    reportID.Text = dr["ReportId"].ToString();
                    dateOfSubmission.Text = Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy");
                    reportTitleTextBox.Text = dr["Title"].ToString();
                    typeOfCorruptionTextBox.Text = dr["TypeOfCorruption"].ToString();
                    locationTextBox.Text = dr["Location"].ToString();
                    reportDescriptionRichTextBox.Text = dr["Description"].ToString();
                    submittedByTextBox.Text = dr["SubmittedBy"].ToString();
                    statusComboBox.SelectedItem = dr["Status"].ToString();
                }
                else
                {
                    MessageBox.Show("No assigned report found with this Report ID.");
                }
                con.Close();
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(reportID.Text, out int reportId) && !string.IsNullOrWhiteSpace(statusComboBox.Text))
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("UPDATE Reports SET Status = @Status WHERE ReportId = @ReportId", con, transaction);
                        cmd1.Parameters.AddWithValue("@Status", statusComboBox.Text);
                        cmd1.Parameters.AddWithValue("@ReportId", reportId);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"INSERT INTO ReportHistory (ReportId, Status, ChangedBy, Note, Timestamp)
                                                            VALUES (@ReportId, @Status, @ChangedBy, @Note, GETDATE())", con, transaction);
                        cmd2.Parameters.AddWithValue("@ReportId", reportId);
                        cmd2.Parameters.AddWithValue("@Status", statusComboBox.Text);
                        cmd2.Parameters.AddWithValue("@ChangedBy", currentUserId);
                        cmd2.Parameters.AddWithValue("@Note", investigatorNotesrichTextBox.Text.Trim());
                        cmd2.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Report status updated successfully.");
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error updating report: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure Report ID and Status are correctly filled.");
            }
        }

        private void ClearFields()
        {
            reportID.Text = "00";
            dateOfSubmission.Text = "01/01/2000";
            reportTitleTextBox.Clear();
            typeOfCorruptionTextBox.Clear();
            locationTextBox.Clear();
            reportDescriptionRichTextBox.Clear();
            submittedByTextBox.Clear();
            statusComboBox.SelectedIndex = -1;
            investigatorNotesrichTextBox.Clear();
        }

        private void reportIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void reportTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
