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

namespace SpeakOut___Anti_Corruption_Reporting_System.Reporter
{
    public partial class ReporterDashboard : Form
    {
        private int currentUserId;
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ReporterDashboard()
        {
            InitializeComponent();
        }

        public ReporterDashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            lblWelcomeReporter.Text = $"Welcome, Reporter #{currentUserId}";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Reports WHERE SubmittedBy = @UserId", con);
                cmd1.Parameters.AddWithValue("@UserId", currentUserId);
                lblTotalReportsSubmitted.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Reports WHERE SubmittedBy = @UserId AND Status = 'Under Review'", con);
                cmd2.Parameters.AddWithValue("@UserId", currentUserId);
                lblReportsUnderReview.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Reports WHERE SubmittedBy = @UserId AND Status = 'Resolved'", con);
                cmd3.Parameters.AddWithValue("@UserId", currentUserId);
                lblResolvedReports.Text = cmd3.ExecuteScalar().ToString();

                con.Close();
            }
        }

        private void ReporterDashboard_Load(object sender, EventArgs e)
        {

        }

        private void reporterSubmitNewReportBTN_Click(object sender, EventArgs e)
        {
            ReporterSubmitNewReport submitForm = new ReporterSubmitNewReport(currentUserId);
            submitForm.ShowDialog();
        }
    }
}
