using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System.Reporter
{
    public partial class ReporterSubmitNewReport : Form
    {
        string selectedFilePath = "";
        private int currentUserId;

        public ReporterSubmitNewReport()
        {
            InitializeComponent();
        }

        public ReporterSubmitNewReport(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void chooseFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                evidenceTextBox.Text = selectedFilePath;

                evidenceListBox.Items.Clear();
                evidenceListBox.Items.Add(Path.GetFileName(selectedFilePath));
            }
        }

        private void newReportSubmitBTN_Click(object sender, EventArgs e)
        {
            string title = reportTitleTextBox.Text.Trim();
            string description = reportDescriptionRichTextBox.Text.Trim();
            string location = locationTextBox.Text.Trim();
            string typeOfCorruption = typeOfCorruptionComboBox.Text.Trim();
            DateTime reportDate = dateofIncidentDateTimePicker.Value;

            bool isAnonymous = submitAnonymously.Checked;
            bool isWithIdentity = submitNone.Checked;

            int? submittedBy = null;
            int isAnonymousFlag = 0;

            if (isAnonymous)
            {
                submittedBy = null;
                isAnonymousFlag = 1;
            }
            else if (isWithIdentity)
            {
                submittedBy = currentUserId;
                isAnonymousFlag = 0;
            }
            else
            {
                MessageBox.Show("Please select identity option.");
                return;
            }

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Title and Description are required.");
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Reports (Title, Description, TypeOfCorruption, Location, Date, SubmittedBy, IsAnonymous)
                        OUTPUT INSERTED.ReportId
                        VALUES (@Title, @Description, @Type, @Location, @Date, @SubmittedBy, @IsAnonymous)", conn, transaction);

                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Type", typeOfCorruption);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@Date", reportDate);
                    cmd.Parameters.AddWithValue("@IsAnonymous", isAnonymousFlag);
                    if (submittedBy.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@SubmittedBy", submittedBy.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SubmittedBy", DBNull.Value);
                    }

                    int reportId = (int)cmd.ExecuteScalar();

                    if (!string.IsNullOrEmpty(selectedFilePath))
                    {
                        string destFolder = Path.Combine(Application.StartupPath, "EvidenceFiles");
                        if (!Directory.Exists(destFolder))
                            Directory.CreateDirectory(destFolder);

                        string fileName = Path.GetFileName(selectedFilePath);
                        string destPath = Path.Combine(destFolder, fileName);
                        File.Copy(selectedFilePath, destPath, true);

                        SqlCommand evCmd = new SqlCommand(@"
                            INSERT INTO Evidence (ReportId, FilePath, FileType)
                            VALUES (@ReportId, @FilePath, @FileType)", conn, transaction);

                        evCmd.Parameters.AddWithValue("@ReportId", reportId);
                        evCmd.Parameters.AddWithValue("@FilePath", destPath);
                        evCmd.Parameters.AddWithValue("@FileType", Path.GetExtension(fileName));
                        evCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Report submitted successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void submitAnonymously_CheckedChanged(object sender, EventArgs e)
        {
            if (submitAnonymously.Checked)
                submitNone.Checked = false;
        }

        private void submitNone_CheckedChanged(object sender, EventArgs e)
        {
            if (submitNone.Checked)
                submitAnonymously.Checked = false;
        }
    }
}
