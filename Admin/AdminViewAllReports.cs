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
    public partial class AdminViewAllReports : Form
    {
        public AdminViewAllReports()
        {
            InitializeComponent();
            BindReportsGridView();
        }

        private void BindReportsGridView()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
            SELECT 
                r.ReportId, 
                r.Title, 
                ISNULL(u.Name, 'Anonymous') AS SubmittedBy, 
                r.TypeOfCorruption, 
                r.Location, 
                r.Date, 
                r.Status, 
                ISNULL(i.Name, 'Not Assigned') AS AssignedTo
            FROM Reports r
            LEFT JOIN Users u ON r.SubmittedBy = u.UserId
            LEFT JOIN ReportAssignments ra ON r.ReportId = ra.ReportId
            LEFT JOIN Users i ON ra.InvestigatorId = i.UserId";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                reportsDataGridView.DataSource = dt;
            }
        }


        private void reportsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
