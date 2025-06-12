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
    public partial class ReporterMySubmittedEvidence : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int currentUserId;
        public ReporterMySubmittedEvidence()
        {
            InitializeComponent();
        }

        public ReporterMySubmittedEvidence(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            BindGridView();
        }

        private void BindGridView()
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("User ID is not set. Cannot load reports.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        e.EvidenceId, 
                        e.ReportId, 
                        e.FilePath, 
                        e.FileType, 
                        e.UploadedAt
                    FROM Evidence e
                    INNER JOIN Reports r ON e.ReportId = r.ReportId
                    WHERE r.SubmittedBy = @SubmittedBy
                    ORDER BY e.UploadedAt DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@SubmittedBy", currentUserId);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                reporterEvidenceDataGridView.DataSource = dt;

                reporterEvidenceDataGridView.Columns["EvidenceId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                reporterEvidenceDataGridView.Columns["ReportId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                reporterEvidenceDataGridView.Columns["FilePath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                reporterEvidenceDataGridView.Columns["FileType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            BindGridView();
            MessageBox.Show("Evidence list refreshed successfully!");
        }
    }
}
