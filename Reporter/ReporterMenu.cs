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
    public partial class ReporterMenu : Form
    {
        public ReporterMenu()
        {
            InitializeComponent();
        }

        private void LoadFormInPanel(Form form)
        {
            reporterPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            reporterPanel.Controls.Add(form);
            form.Show();
        }

        private void reporterDashboardBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Reporter.ReporterDashboard());
        }

        private void reporterSubmitNewReportBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Reporter.ReporterSubmitNewReport());
        }

        private void reporterMyReportsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Reporter.ReporterMyReports());
        }

        private void reporterReportStatusTracker_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Reporter.ReportStatusTracker());
        }

        private void reporterMySubmittedEvidenceBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Reporter.ReporterMySubmittedEvidence());
        }

        private void reporterCommentsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Reporter.ReporterComments());
        }

        private void reporterLogoutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
