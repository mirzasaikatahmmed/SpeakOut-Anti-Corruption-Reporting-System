using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void LoadFormInPanel(Form form)
        {
            adminPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            adminPanel.Controls.Add(form);
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminUserManagementBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminUserManagement());
        }

        private void adminDashboardBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminDashboard());
        }

        private void ACLOSEBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminLogoutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void adminManageInvestigatorsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminInvestigatorsManagement());
        }

        private void adminAllReportBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminViewAllReports());
        }

        private void assignReportBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminAssignReports());
        }

        private void adminReportHistoryBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminReportHistory());
        }

        private void adminNotificationLogBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Admin.AdminNotificationLog());
        }
    }
}
