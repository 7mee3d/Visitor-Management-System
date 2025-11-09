using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Management_System
{
    public partial class VMS_Login : Form
    {
        public VMS_Login()
        {
            InitializeComponent();
        }

        private async void showOverLayAfterClickLogIn()
        {
            siticoneOverlayButtonLogIn.Show = true;

            await Task.Delay(5000);

            siticoneOverlayButtonLogIn.Show = false;

            //Test LogIn System
            MessageBox.Show("Done Login VMS");
        }

        private void GButtonLogIn_Click(object sender, EventArgs e)
        {
            showOverLayAfterClickLogIn();

        }

    
    }
}
