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
    public partial class InvestigatorDashboard : Form
    {
        private int currentUserId;
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public InvestigatorDashboard()
        {
            InitializeComponent();
        }

        public InvestigatorDashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            lblWelcomeInvestigator.Text = $"Welcome, Investigator #{currentUserId}";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM ReportAssignments WHERE InvestigatorId = @UserId", con);
                cmd1.Parameters.AddWithValue("@UserId", currentUserId);
                lblTotalAssignedReports.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand(@"
                    SELECT COUNT(*) FROM Reports r
                    INNER JOIN ReportAssignments ra ON r.ReportId = ra.ReportId
                    WHERE ra.InvestigatorId = @UserId AND r.Status = 'Pending'", con);
                cmd2.Parameters.AddWithValue("@UserId", currentUserId);
                lblPendingReports.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand(@"
                    SELECT COUNT(*) FROM Reports r
                    INNER JOIN ReportAssignments ra ON r.ReportId = ra.ReportId
                    WHERE ra.InvestigatorId = @UserId AND r.Status = 'Under Review'", con);
                cmd3.Parameters.AddWithValue("@UserId", currentUserId);
                lblInProgressReports.Text = cmd3.ExecuteScalar().ToString();

                con.Close();
            }
        }
    }
}
