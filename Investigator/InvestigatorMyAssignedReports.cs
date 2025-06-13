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
    public partial class InvestigatorMyAssignedReports : Form
    {
        private int currentUserId;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public InvestigatorMyAssignedReports()
        {
            InitializeComponent();
        }

        public InvestigatorMyAssignedReports(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadAssignedReports();
        }

        private void LoadAssignedReports()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        r.ReportId,
                        r.Title,
                        u.Name AS SubmittedBy,
                        r.TypeOfCorruption,
                        r.Location,
                        r.Date AS SubmittedOn,
                        r.Status
                    FROM Reports r
                    INNER JOIN ReportAssignments ra ON r.ReportId = ra.ReportId
                    LEFT JOIN Users u ON r.SubmittedBy = u.UserId
                    WHERE ra.InvestigatorId = @UserId
                    ORDER BY r.Date DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                investigatorReportDataGridView.DataSource = dt;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadAssignedReports();
            MessageBox.Show("Reports refreshed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
