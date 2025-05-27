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
    public partial class AdminUserManagement : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminUserManagement()
        {
            InitializeComponent();
            BindGridView();
        }

        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT UserId, Name, Email, Role, CreatedAt FROM Users WHERE Role = 'Reporter'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            userDataGridView.DataSource = dt;

            userDataGridView.Columns["UserId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userDataGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          
            if (userDataGridView.Columns.Contains("Role"))
            {
                userDataGridView.Columns["Role"].Visible = false;
            }
            if (userDataGridView.Columns.Contains("CreatedAt"))
            {
                userDataGridView.Columns["CreatedAt"].Visible = false;
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {

        }

        private void updateUser_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            BindGridView();
            MessageBox.Show("Data Refresh Successful");
        }
    }
}
