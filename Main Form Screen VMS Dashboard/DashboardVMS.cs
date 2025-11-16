using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visitor_Management_System.User_Control_VMS;

namespace Visitor_Management_System.Main_Form_Screen_VMS_Dashboard
{
    public partial class DashboardVMS : Form
    {

        bool mouseDown = false;
        int mouseX = 0;
        int mouseY = 0;


        public DashboardVMS()        
        {
            InitializeComponent();
        }

        private void setUserControlInMainPanelVMS (UserControl UserControlSections)
        {
            GMainPanelVMS.Controls.Clear();
            UserControlSections.Dock = DockStyle.Fill;

            GMainPanelVMS.Controls.Add(UserControlSections);
            UserControlSections.BringToFront();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void GButtonDashboardSection_Click(object sender, EventArgs e)
        {
            UserControlSectionDashboard UCSD = new UserControlSectionDashboard();
            setUserControlInMainPanelVMS(UserControlSections:  UCSD);
        }

        private void GButtonAddNewVisitorSection_Click(object sender, EventArgs e)
        {
            UserControlSectionAddNewVisitor UCSANV = new UserControlSectionAddNewVisitor();
            setUserControlInMainPanelVMS(UserControlSections:  UCSANV);

        }

        private void GButtonCheckOutSection_Click(object sender, EventArgs e)
        {
            UserControlSectionCheckOut UCSCO = new UserControlSectionCheckOut();
            setUserControlInMainPanelVMS(UserControlSections:  UCSCO);
        }

        private void GButtonCurrentVisitorSection_Click(object sender, EventArgs e)
        {
            UserControlSectionCurrentVisitors UCSCV = new UserControlSectionCurrentVisitors();
            setUserControlInMainPanelVMS( UserControlSections :  UCSCV);
        }

        private void GButtonSettingsSSection_Click(object sender, EventArgs e)
        {
            UserControlSectionSettings UCSS = new UserControlSectionSettings();
            setUserControlInMainPanelVMS(UserControlSections: UCSS);

        }

        private void GGPanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y; 
        }

        private void GGPanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left += e.X -  mouseX; 
                this.Top += e.Y - mouseY; 
            }
        }

        private void GGPanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void GButtonLogOutAccount_Click(object sender, EventArgs e)
        {
            Visitor_Management_System.VMS_Login frmLoginVMSScreen = new Visitor_Management_System.VMS_Login();

            //Form DashBoard Screen
            this.Close();
            frmLoginVMSScreen.Show();

        }
    }
}
