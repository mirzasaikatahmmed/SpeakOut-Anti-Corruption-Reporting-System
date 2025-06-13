using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System.Investigator
{
    public partial class InvestigatorProgressHistory : Form
    {
        private int currentUserId;
        public InvestigatorProgressHistory()
        {
            InitializeComponent();
        }

        public InvestigatorProgressHistory(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
    }
}
