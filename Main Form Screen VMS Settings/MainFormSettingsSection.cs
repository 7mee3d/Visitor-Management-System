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
using Visitor_Management_System.User_Controls_Main_Form_Settings_Section_VMS;

namespace Visitor_Management_System.Main_Form_Screen_VMS_Settings
{
    public partial class MainFormSettingsSection : Form
    {

        private void setTheUserControlInThePanel (UserControl UserDefine_UserControl)
        {

            GMainPanelSettingsVMS.Controls.Clear();
            GMainPanelSettingsVMS.Dock = DockStyle.Fill;
            GMainPanelSettingsVMS.Controls.Add(UserDefine_UserControl);

            UserDefine_UserControl.BringToFront();

        }
      
        private void setTheUserControlAfterLoadTheFormSettins()
        {
            UserControlSectionUserInformationFormSettings UCSUIFS = new UserControlSectionUserInformationFormSettings();

            setTheUserControlInThePanel(UserDefine_UserControl: UCSUIFS);
        }
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
            setTheUserControlAfterLoadTheFormSettins();
        }

        private void GButtonReturnMainFormVMS_Click(object sender, EventArgs e)
        {
            OpenMainVMSAndCloseSectionSettings();
        }

        private void GButtonUserInformationSection_Click(object sender, EventArgs e)
        {
            UserControlSectionUserInformationFormSettings UCSUIFS = new UserControlSectionUserInformationFormSettings();

            setTheUserControlInThePanel(UserDefine_UserControl : UCSUIFS);
        }

        private void GButtonUsersSection_Click(object sender, EventArgs e)
        {
            UserControlSectionUsersFormSettings UCSUFS  = new UserControlSectionUsersFormSettings();
            setTheUserControlInThePanel(UserDefine_UserControl: UCSUFS);

        }

        private void GButtonDepartmentSection_Click(object sender, EventArgs e)
        {
            UserControlSectionDepartmentormSettings UCSDS = new UserControlSectionDepartmentormSettings();
            setTheUserControlInThePanel(UserDefine_UserControl: UCSDS);
        }

        private void MainFormSettingsSection_Load(object sender, EventArgs e)
        {

        }
    }
}
