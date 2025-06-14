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
    public partial class InvestigatorProgressHistory : Form
    {
        private int currentUserId;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public InvestigatorProgressHistory()
        {
            InitializeComponent();
        }

        public InvestigatorProgressHistory(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadProgressHistory();
        }

        private void LoadProgressHistory()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                SELECT r.ReportId,
                       r.Title AS [Report Title],
                       r.Status,
                       MAX(ISNULL(rh.Timestamp, r.CreatedAt)) AS [Last Updated],
                       COUNT(c.CommentId) AS [Total Comments],
                       MAX(c.Timestamp) AS [Last Comment Date],
                       LEFT(MAX(rh.Note), 100) + CASE WHEN LEN(MAX(rh.Note)) > 100 THEN '...' ELSE '' END AS [Investigator Notes]
                FROM Reports r
                INNER JOIN ReportAssignments ra ON ra.ReportId = r.ReportId
                LEFT JOIN Comments c ON c.ReportId = r.ReportId
                LEFT JOIN ReportHistory rh ON rh.ReportId = r.ReportId
                WHERE ra.InvestigatorId = @InvestigatorId
                GROUP BY r.ReportId, r.Title, r.Status, r.CreatedAt
                ORDER BY [Last Updated] DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@InvestigatorId", currentUserId);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                progressHistoryDataGridView.DataSource = dt;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadProgressHistory();
            MessageBox.Show("Progress history refreshed successfully.");
        }
    }
}
