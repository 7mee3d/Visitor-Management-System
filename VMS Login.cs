using Guna.UI2.WinForms;
using SiticoneNetFrameworkUI;
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
using Visitor_Management_System.Main_Form_Screen_VMS_Settings;
using Visitor_Management_System.User_Controls_Main_Form_Settings_Section_VMS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Visitor_Management_System
{
  

    public partial class VMS_Login : Form
    {

        public enum enRolesVMS : int
        {
            _enkADMIN_ROLE = -1,
            _enkNOTHING = 0
        };

        public class stcInformatonUser
        {

            public string stNameUser;
            public string stEmailUser;
            public string stUsername;
            public string stPasswordUser;
            public enRolesVMS stEN_Role;
            public short stAttempt;

            public stcInformatonUser()
            {

                stNameUser = "";
                stEmailUser = "";
                stUsername = "";
                stPasswordUser = "";
                 stEN_Role = enRolesVMS._enkNOTHING;
                stAttempt = 0;


            }

        };


        private const string _kFILE_PATH_USERS_INFORMATION = @"../../Data_Information_VMS/Information_Users.txt";
        private const string _kSEPARATOR_FILE_USERS_INFORMATION = "$$||$$";
        private const ushort _kSTART_SAVE_AND_READ_FROM_FILE_USER_INFORMATION = 15; 
        private const ushort _kCOUNT_PARTS_INFORMATION_USERS = 6; 
        private const string _kBANNER_FILE_USERS_INFORMATION = @"
 _____                                                                                                     _____ 
( ___ )                                                                                                   ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |                                                                                                     |   | 
 |   |                                                                                                     |   | 
 |   |         ___        __                            _   _                  _   _                       |   | 
 |   |        |_ _|_ __  / _| ___  _ __ _ __ ___   __ _| |_(_) ___  _ __      | | | |___  ___ _ __         |   | 
 |   |         | || '_ \| |_ / _ \| '__| '_ ` _ \ / _` | __| |/ _ \| '_ \     | | | / __|/ _ \ '__|        |   | 
 |   |         | || | | |  _| (_) | |  | | | | | | (_| | |_| | (_) | | | |    | |_| \__ \  __/ |           |   | 
 |   |        |___|_| |_|_|  \___/|_|  |_| |_| |_|\__,_|\__|_|\___/|_| |_|     \___/|___/\___|_|           |   | 
 |   |                                                                                                     |   | 
 |   |                                                                                                     |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                                                                   (_____) 
";

        public VMS_Login()
        {
            InitializeComponent();

            //Activate the Login VMS OF The Top 
            this.TopMost = true;
            this.TopMost = false;
            this.Activate();
            
        }
       
        //General Methods 
        private async void showOverLayAfterClickLogInShowDashBoardVMS()
        {
            siticoneOverlayButtonLogIn.Show = true;

            await Task.Delay(5000);

            siticoneOverlayButtonLogIn.Show = false;

            Visitor_Management_System.Main_Form_Screen_VMS_Dashboard.DashboardVMS frmDashboardScreenVMS = new Visitor_Management_System.Main_Form_Screen_VMS_Dashboard.DashboardVMS();
            frmDashboardScreenVMS.Show();
            //Form Login VMS Screen 
            this.Hide();
        }

       /* private void ClearAllTextBox()
        {

            foreach(Control outterControl in this.Controls)
            {
                if(outterControl is Guna2Panel G2P)
                {
                    foreach(Control innerControl in G2P.Controls)
                    {
                        if(innerControl is SiticoneTextBoxAdvanced STBA)
                        {
                            STBA.Text = "";
                        }
                    }
                }
            }
        }*/

        private void ExitVMS()
        {
            Application.Exit();
        }

        private void setPropertiesNotifyIconVMSLoginAfterMinimaizeLogin()
        {


            WindowState = FormWindowState.Minimized;
            notifyIconMinimzeLoginVMS.Visible = true;

            notifyIconMinimzeLoginVMS.ShowBalloonTip(1500, "VMS Login", "Log In To Your VMS", ToolTipIcon.Info);

            this.Hide();
        }

        private void setPropertiesNotifiyIconVMSLoginAfterClickBallonOrIconORMenu()
        {

            this.Show();
            notifyIconMinimzeLoginVMS.Visible = false;
            WindowState = FormWindowState.Normal;

            
            //Makes the form appear above all other windows 
            this.TopMost = true;
            //Set the Default Top Most 
            this.TopMost = false;
            //give the Focus full marks.
            this.Activate();

        }

        private stcInformatonUser RetrurnEmptyStructureInformationUser()
        {
            return new stcInformatonUser();
        }

        private List<string> LoadAllLinesInformationFromFile (string pathFile)
        {
            List<string> allInformationAfterReadFromFile = new List<string>();

            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamReader ReadAllLinesFromFile = new System.IO.StreamReader(pathFile);

            string line = "";
            while((line = ReadAllLinesFromFile.ReadLine() ) != null)
            {
                allInformationAfterReadFromFile.Add(line);
            }

            ReadAllLinesFromFile.Close();

            return allInformationAfterReadFromFile; 

        }     

        private void SaveAllInformationAfterChangeData(string pathFile  , List<stcInformatonUser> newInformationChanged )
        {
            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamWriter WriteAllInformationInFile = new System.IO.StreamWriter(pathFile  );

            WriteAllInformationInFile.WriteLine(_kBANNER_FILE_USERS_INFORMATION);

            foreach (stcInformatonUser infoOneUser in newInformationChanged )
            {
                if(infoOneUser != null )
                WriteAllInformationInFile.WriteLine(ConvertDataInformationUserToLine(infoOneUser, _kSEPARATOR_FILE_USERS_INFORMATION));
            }

            WriteAllInformationInFile.Close(); 

        }
  
        private List<string> SplitLineProducesSubInformation (string line , string Separator )
        {
            List<string> informationAfterSplit = new List<string>();
            if (!string.IsNullOrEmpty(line))
            {
                informationAfterSplit.AddRange(line.Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries));
            }
            return informationAfterSplit;

        }
 
        private stcInformatonUser ConvertLineInformationUserToData (List<string> informationUser)
        {
            stcInformatonUser informationUserData = new stcInformatonUser();

            if (informationUser.Count >= _kCOUNT_PARTS_INFORMATION_USERS) 
            {
                informationUserData.stNameUser = informationUser[0];
                informationUserData.stEmailUser = informationUser[1];
                informationUserData.stUsername = informationUser[2];
                informationUserData.stPasswordUser = informationUser[3];
                informationUserData.stEN_Role = (enRolesVMS)Convert.ToInt32 ( informationUser[4]);
                informationUserData.stAttempt = Convert.ToInt16(informationUser[5]);
            }
            return informationUserData; 

        }
     
        private string ConvertDataInformationUserToLine (stcInformatonUser informationUser , string Separator )
        {
            string lineInformationUser = "";

            lineInformationUser += informationUser.stNameUser + Separator;
            lineInformationUser += informationUser.stEmailUser + Separator;
            lineInformationUser += informationUser.stUsername + Separator;
            lineInformationUser += informationUser.stPasswordUser + Separator;
            lineInformationUser += Convert.ToInt32( informationUser.stEN_Role ) + Separator;
            lineInformationUser += informationUser.stAttempt ;

            return lineInformationUser;
        }
       
        private List<stcInformatonUser> LoadAllInformationDataUsersToListStructure(  )
        {
            List<stcInformatonUser> allInformationUsersData = new List<stcInformatonUser>();

            List<string> allLinesInformation = LoadAllLinesInformationFromFile(pathFile: _kFILE_PATH_USERS_INFORMATION);

            for (int counter = _kSTART_SAVE_AND_READ_FROM_FILE_USER_INFORMATION; counter < allLinesInformation.Count; counter++)
            {
                List<string> userAllInformationList = SplitLineProducesSubInformation(allLinesInformation[counter], _kSEPARATOR_FILE_USERS_INFORMATION);

                if(userAllInformationList.Count >= _kCOUNT_PARTS_INFORMATION_USERS)
                allInformationUsersData.Add(ConvertLineInformationUserToData(userAllInformationList));
            
            }

            return allInformationUsersData; 
        }
    
        private stcInformatonUser SearchUserInFile (string Username )
        {
            List<stcInformatonUser> AllInformationUsersSt = LoadAllInformationDataUsersToListStructure();

            foreach (stcInformatonUser infoOneUser in AllInformationUsersSt )
                if (infoOneUser.stUsername == Username) return infoOneUser;


            return RetrurnEmptyStructureInformationUser();
        }

        private bool isUserExitsInSystem(string Username)
        {
            List<stcInformatonUser> AllInformationUsersSt = LoadAllInformationDataUsersToListStructure();

            foreach (stcInformatonUser infoOneUser in AllInformationUsersSt)
                if (infoOneUser.stUsername == Username) return true ;


            return false;
        }
   
        private void UpdateInformationListStructure (stcInformatonUser informationUser , string username )
        {
            List<stcInformatonUser> AllInformationUsersSt = LoadAllInformationDataUsersToListStructure();

          for(int counter = 0; counter < AllInformationUsersSt.Count; counter++)
            {
                if (AllInformationUsersSt[counter].stUsername == username)
                {
                    AllInformationUsersSt[counter] = informationUser;
                    SaveAllInformationAfterChangeData(_kFILE_PATH_USERS_INFORMATION, AllInformationUsersSt);
                    return; 
                }

            }


        }
     
        private bool areEqualPassword (string PasswordOne , string PasswordTwo )
        {
            return (PasswordOne == PasswordTwo);
        }
        
        private void ChangeAttemptAndLabelShowMessageAfterClickLogIn(short numberAttempt , ref stcInformatonUser CarruntUserInfo , string Message )
        {
            CarruntUserInfo.stAttempt = numberAttempt;
            LblShowMessageWrongPasswordOrLockAccount.Text = Message; 
        }

        private void LogInVMS()
        {
            string username = siticoneTextBoxUsername.Text.Trim();
            string password = siticoneTextBoxPassword.Text.Trim(); 


            if(isUserExitsInSystem(username))
            {
                stcInformatonUser allInformationThisUserAfterSearch = SearchUserInFile(username);

                if (
                    areEqualPassword(password , allInformationThisUserAfterSearch.stPasswordUser)
                    )
                {
                    if (allInformationThisUserAfterSearch.stAttempt > 0)
                    {
                        ChangeAttemptAndLabelShowMessageAfterClickLogIn(3 ,ref allInformationThisUserAfterSearch, "");
                        showOverLayAfterClickLogInShowDashBoardVMS();
                      
                      
                    }
                    else
                        LblShowMessageWrongPasswordOrLockAccount.Text = "This account is Locked";
                }
                else
                {
                    LblShowMessageWrongPasswordOrLockAccount.Text = "Password is Wronge , Please Enter Correct Password";
                    siticoneTextBoxPassword.Focus();
                    if (
                        allInformationThisUserAfterSearch.stAttempt > 0
                        )
                        allInformationThisUserAfterSearch.stAttempt--;
                    else
                        LblShowMessageWrongPasswordOrLockAccount.Text = "This account is Locked";


                    siticoneTextBoxPassword.Clear();
                }

                UpdateInformationListStructure(allInformationThisUserAfterSearch, username);
            }
            else
            {
                //ClearAllTextBox();
                siticoneTextBoxUsername.Clear();
                siticoneTextBoxPassword.Clear();
                siticoneTextBoxUsername.Focus();
                LblShowMessageWrongPasswordOrLockAccount.Text = "This account does not exist. Please Contact Adminto Create\nNew Account in VMS";
              
            }
            
        }
     
        private void GButtonLogIn_Click(object sender, EventArgs e)
        {
            LogInVMS();

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            ExitVMS();      
        }

        private void siticoneControlBoxMinimize_Click(object sender, EventArgs e)
        {
            setPropertiesNotifyIconVMSLoginAfterMinimaizeLogin();
        }

        private void notifyIconMinimzeLoginVMS_BalloonTipClicked(object sender, EventArgs e)
        {
            setPropertiesNotifiyIconVMSLoginAfterClickBallonOrIconORMenu();

        }

        private void showToolStripMenuItemShowLoginVMS_Click(object sender, EventArgs e)
        {
            setPropertiesNotifiyIconVMSLoginAfterClickBallonOrIconORMenu();
        }

        private void exitToolStripMenuItemExitVMS_Click(object sender, EventArgs e)
        {
            ExitVMS();
        }

        private void notifyIconMinimzeLoginVMS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setPropertiesNotifiyIconVMSLoginAfterClickBallonOrIconORMenu();

        }

    
    }
}
