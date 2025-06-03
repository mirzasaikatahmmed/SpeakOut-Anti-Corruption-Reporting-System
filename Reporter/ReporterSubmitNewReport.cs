using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System.Reporter
{
    public partial class ReporterSubmitNewReport : Form
    {
        List<string> evidenceFiles = new List<string>();

        public ReporterSubmitNewReport()
        {
            InitializeComponent();
        }

        private void chooseFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    evidenceFiles.Add(file);
                    evidenceListBox.Items.Add(Path.GetFileName(file));
                }
            }
        }
    }
}
