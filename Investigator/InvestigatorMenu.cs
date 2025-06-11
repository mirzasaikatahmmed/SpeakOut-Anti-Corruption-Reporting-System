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
    public partial class InvestigatorMenu : Form
    {
        private int currentUserId;
        public InvestigatorMenu()
        {
            InitializeComponent();
        }
        
        public InvestigatorMenu(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void LoadFormInPanel(Form form)
        {
            investigatorPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            investigatorPanel.Controls.Add(form);
            form.Show();
        }

        private void investigatorDashboardBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Investigator.InvestigatorDashboard());
        }

        private void investigatorMyAssignedReportsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Investigator.InvestigatorMyAssignedReports());
        }

        private void investigatorReviewReportBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Investigator.InvestigatorReportReview());
        }

        private void investigatorUploadEvidenceBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Investigator.InvestigatorUploadEvidence());
        }

        private void investigatorCommentsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Investigator.InvestigatorComments());
        }

        private void investigatorProgressHistoryBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Investigator.InvestigatorProgressHistory());
        }

        private void investigatorLogoutBTN_Click(object sender, EventArgs e)
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
