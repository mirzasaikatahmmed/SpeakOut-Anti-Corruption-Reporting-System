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
    public partial class ReportStatusTracker : Form
    {
        private int currentUserId;
        public ReportStatusTracker()
        {
            InitializeComponent();
        }
        public ReportStatusTracker(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string reportIdText = reportIDtextBox.Text.Trim();
            if (int.TryParse(reportIdText, out int reportId))
            {
                LoadReportById(reportId);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Report ID.");
            }
        }

        private void LoadReportById(int reportId)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT HistoryId, Status, ChangedBy, Note, Timestamp
                    FROM ReportHistory
                    WHERE ReportId = @ReportId
                    ORDER BY Timestamp DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReportId", reportId);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                reporterReportStatusDataGridView.DataSource = dt;
            }
        }
    }
}
