using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visitor_Management_System.Main_Form_Screen_VMS_Settings;
using Visitor_Management_System.User_Control_VMS;

namespace Visitor_Management_System.Main_Form_Screen_VMS_Dashboard
{
    public partial class DashboardVMS : Form
    {

        bool mouseDown = false;
        private int _MouseX = 0;
        private int _MouseY = 0;


        private string getYearFromSystem ()
        {
            return DateTime.Now.ToString("yyyy");
        }

        public DashboardVMS()        
        {
            InitializeComponent();
            YearAllRightReserved.Text = "@ " + getYearFromSystem();
        }
      
      
        
        private void OpenSectionSetting()
        {
            MainFormSettingsSection MFSS = new MainFormSettingsSection();
            this.Hide();
            MFSS.ShowDialog();

        }
       
        private void setUserControlInMainPanelVMS (UserControl UserControlSections)
        {
            GMainPanelVMS.Controls.Clear();
            UserControlSections.Dock = DockStyle.Fill;

            GMainPanelVMS.Controls.Add(UserControlSections);
            UserControlSections.BringToFront();
        }

        private void showSectionDashboard(UserControl nameUserControl )
        {
            setUserControlInMainPanelVMS(nameUserControl);
        }
   
        private void GButtonDashboardSection_Click(object sender, EventArgs e)
        {
            UserControlSectionDashboard UCSD = new UserControlSectionDashboard();
            showSectionDashboard(nameUserControl : UCSD);


        }

        private void GButtonAddNewVisitorSection_Click(object sender, EventArgs e)
        {
            UserControlSectionAddNewVisitor UCSANV = new UserControlSectionAddNewVisitor();
            showSectionDashboard(nameUserControl:  UCSANV);
        }

        private void GButtonCheckOutSection_Click(object sender, EventArgs e)
        {
            UserControlSectionCheckOut UCSCO = new UserControlSectionCheckOut();
            showSectionDashboard(nameUserControl:  UCSCO);
        }

        private void GButtonCurrentVisitorSection_Click(object sender, EventArgs e)
        {
            UserControlSectionCurrentVisitors UCSCV = new UserControlSectionCurrentVisitors();
            showSectionDashboard(nameUserControl:  UCSCV);
        }

        private void GGPanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            _MouseX = e.X;
            _MouseY = e.Y; 
        }

        private void GGPanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left += e.X - _MouseX; 
                this.Top += e.Y - _MouseY; 
            }
        }

        private void GGPanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LogOutAccountInVMS()
        {
            Visitor_Management_System.VMS_Login frmLoginVMSScreen = new Visitor_Management_System.VMS_Login();

            //Form DashBoard Screen
            this.Close();
            frmLoginVMSScreen.Show();
        }

        private void GButtonLogOutAccount_Click(object sender, EventArgs e)
        {
            LogOutAccountInVMS();

        }

        private void DashboardVMS_Load(object sender, EventArgs e)
        {
            UserControlSectionDashboard UCSD = new UserControlSectionDashboard();

            if (GButtonDashboardSection.Checked) showSectionDashboard(nameUserControl: UCSD);

        }

        private void GButtonSettingsSSection_Click(object sender, EventArgs e)
        {
            OpenSectionSetting();
        }
    }
}
