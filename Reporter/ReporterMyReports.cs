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
    public partial class ReporterMyReports : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int currentUserId;
        public ReporterMyReports()
        {
            InitializeComponent();
        }

        public ReporterMyReports(int userId)
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
                string query = "SELECT ReportId, Title, Description, TypeOfCorruption, Location, Status FROM Reports WHERE SubmittedBy = @SubmittedBy";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@SubmittedBy", currentUserId);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                reporterReportDataGridView.DataSource = dt;

                reporterReportDataGridView.Columns["ReportId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                reporterReportDataGridView.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                reporterReportDataGridView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                reporterReportDataGridView.Columns["TypeOfCorruption"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                reporterReportDataGridView.Columns["Location"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                reporterReportDataGridView.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            BindGridView();
            MessageBox.Show("Data Refresh Successful");
        }
    }
}
