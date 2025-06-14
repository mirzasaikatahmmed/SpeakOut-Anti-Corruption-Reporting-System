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
    public partial class AdminDashboard : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Reports", con);
                totalReports.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Reports WHERE Status = 'Pending'", con);
                totalPendingReports.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Reports WHERE Status = 'Assigned'", con);
                assignedReports.Text = cmd3.ExecuteScalar().ToString();

                SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Role = 'Reporter'", con);
                totalUsers.Text = cmd4.ExecuteScalar().ToString();

                SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Role = 'Investigator'", con);
                totalInvestigators.Text = cmd5.ExecuteScalar().ToString();

                con.Close();
            }
        }
    }
}
