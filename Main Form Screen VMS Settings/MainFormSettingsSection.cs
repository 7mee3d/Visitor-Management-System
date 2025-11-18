using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visitor_Management_System.Main_Form_Screen_VMS_Dashboard;

namespace Visitor_Management_System.Main_Form_Screen_VMS_Settings
{
    public partial class MainFormSettingsSection : Form
    {
        private void OpenMainVMSAndCloseSectionSettings()
        {
            DashboardVMS DVMS = new DashboardVMS();

            this.Hide();
            this.Close();
            DVMS.ShowDialog();
        }
        public MainFormSettingsSection()
        {
            InitializeComponent();
        }

        private void GButtonReturnMainFormVMS_Click(object sender, EventArgs e)
        {
            OpenMainVMSAndCloseSectionSettings();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
