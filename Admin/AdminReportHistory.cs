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
    public partial class AdminReportHistory : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminReportHistory()
        {
            InitializeComponent();
            LoadAllReportHistory();
        }

        private void LoadAllReportHistory()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT rh.HistoryId, rh.ReportId, rh.Status, 
                                        ISNULL(u.Name, 'System') AS ChangedBy, 
                                        rh.Note, rh.Timestamp
                                 FROM ReportHistory rh
                                 LEFT JOIN Users u ON rh.ChangedBy = u.UserId
                                 ORDER BY rh.Timestamp DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                reportHistoryDataGridView.DataSource = dt;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadAllReportHistory();
        }
    }
}
