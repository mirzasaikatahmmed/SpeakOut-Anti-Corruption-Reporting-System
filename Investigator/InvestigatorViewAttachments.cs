using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System.Investigator
{
    public partial class InvestigatorViewAttachments : Form
    {
        private int reportId;
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public InvestigatorViewAttachments(int reportId)
        {
            InitializeComponent();
            this.reportId = reportId;
            LoadEvidenceFiles();
        }

        private void LoadEvidenceFiles()
        {
            lblAttachments.Text = reportId.ToString();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT EvidenceId, FilePath, FileType, UploadedAt FROM Evidence WHERE ReportId = @ReportId";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@ReportId", reportId);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                evidenceGridView.DataSource = dt;

                evidenceGridView.Columns["EvidenceId"].Visible = false;
                evidenceGridView.Columns["FilePath"].HeaderText = "File Name";
                evidenceGridView.Columns["FilePath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evidenceGridView.Columns["FileType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                evidenceGridView.Columns["UploadedAt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void viewFileButton_Click(object sender, EventArgs e)
        {
            if (evidenceGridView.SelectedRows.Count > 0)
            {
                string filePath = evidenceGridView.SelectedRows[0].Cells["FilePath"].Value.ToString();
                if (File.Exists(filePath))
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("File not found: " + filePath);
                }
            }
        }

        private void downloadFileButton_Click(object sender, EventArgs e)
        {
            if (evidenceGridView.SelectedRows.Count > 0)
            {
                string filePath = evidenceGridView.SelectedRows[0].Cells["FilePath"].Value.ToString();
                string fileName = Path.GetFileName(filePath);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = fileName;
                sfd.Filter = "All Files|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(filePath, sfd.FileName, true);
                    MessageBox.Show("File downloaded successfully.");
                }
            }
        }

        private void backPictureBoxBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
