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
    public partial class InvestigatorComments : Form
    {
        private int currentUserId;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public InvestigatorComments()
        {
            InitializeComponent();
        }

        public InvestigatorComments(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(reportIDtextBox.Text))
            {
                MessageBox.Show("Please enter a Report ID.");
                return;
            }

            int reportId;
            if (!int.TryParse(reportIDtextBox.Text.Trim(), out reportId))
            {
                MessageBox.Show("Invalid Report ID format.");
                return;
            }

            LoadReportDetails(reportId);
            LoadPreviousComments(reportId);
        }

        private void LoadReportDetails(int reportId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT Title FROM Reports WHERE ReportId = @ReportId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReportId", reportId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    reportTitleTextBox.Text = dr["Title"].ToString();
                }
                else
                {
                    MessageBox.Show("Report not found.");
                    reportTitleTextBox.Clear();
                    previousCommentsDataGridView.DataSource = null;
                }
                con.Close();
            }
        }

        private void LoadPreviousComments(int reportId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT CommentText AS Comment, UserId AS CommentedBy, Timestamp AS CommentDate 
                         FROM Comments 
                         WHERE ReportId = @ReportId 
                         ORDER BY Timestamp DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@ReportId", reportId);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                previousCommentsDataGridView.DataSource = dt;
            }
        }


        private void commentsBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newCommentsRichTextBox.Text))
            {
                MessageBox.Show("Please write a comment before submitting.");
                return;
            }

            if (!int.TryParse(reportIDtextBox.Text.Trim(), out int reportId))
            {
                MessageBox.Show("Invalid Report ID.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO Comments (ReportId, UserId, CommentText, Timestamp)
                         VALUES (@ReportId, @UserId, @CommentText, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReportId", reportId);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                cmd.Parameters.AddWithValue("@CommentText", newCommentsRichTextBox.Text.Trim());

                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Comment added successfully.");
                    newCommentsRichTextBox.Clear();
                    LoadPreviousComments(reportId);
                }
                else
                {
                    MessageBox.Show("Failed to add comment.");
                }
            }
        }
    }
}
