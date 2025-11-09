using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Visitor_Management_System
{
 
   
    public partial class VMS_Login : Form
    {

        class stcInformatonUser
        {

            public string stNameUser;
            public string stEmailUser;
            public string stUsername;
            public string stPasswordUser;
            public short stAttempt;
            // public short stPermission;

            public stcInformatonUser()
            {

                stNameUser = "";
                stEmailUser = "";
                stUsername = "";
                stPasswordUser = "";
                stAttempt = 0;
                // stPermission = 0;

            }

        };

        private const string _kFILE_PATH_USERS_INFORMATION = @"../../Data_Information_VMS/Information_Users.txt";
        private const string _kSEPARATOR_FILE_USERS_INFORMATION = "$$||$$";

        public VMS_Login()
        {
            InitializeComponent();
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

            foreach (stcInformatonUser infoOneUser in newInformationChanged )
            {
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

            informationUserData.stNameUser = informationUser[0];
            informationUserData.stEmailUser = informationUser[1];
            informationUserData.stUsername = informationUser[2];
            informationUserData.stPasswordUser = informationUser[3];
            informationUserData.stAttempt = Convert.ToInt16 (  informationUser[4]) ;
            //informationUserData.stP = informationUser[3];

            return informationUserData; 

        }
     
        private string ConvertDataInformationUserToLine (stcInformatonUser informationUser , string Separator )
        {
            string lineInformationUser = "";

            lineInformationUser += informationUser.stNameUser + Separator;
            lineInformationUser += informationUser.stEmailUser + Separator;
            lineInformationUser += informationUser.stUsername + Separator;
            lineInformationUser += informationUser.stPasswordUser + Separator;
            lineInformationUser += informationUser.stAttempt ;

            return lineInformationUser;
        }
       
        private List<stcInformatonUser> LoadAllInformationDataUsersToListStructure(  )
        {
            List<stcInformatonUser> allInformationUsersData = new List<stcInformatonUser>();

            List<string> allLinesInformation = LoadAllLinesInformationFromFile(pathFile: _kFILE_PATH_USERS_INFORMATION);

            foreach (string lineInformationOneUser in allLinesInformation)
            {
                allInformationUsersData.Add(ConvertLineInformationUserToData(SplitLineProducesSubInformation(lineInformationOneUser , _kSEPARATOR_FILE_USERS_INFORMATION)));
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
        
        private void LogInVMS()
        {
            string username = siticoneTextBoxUsername.Text;
            string password = siticoneTextBoxPassword.Text; 


            if(isUserExitsInSystem(username))
            {
                stcInformatonUser allInformationThisUserAfterSearch = SearchUserInFile(username);

                if (areEqualPassword(password , allInformationThisUserAfterSearch.stPasswordUser))
                {
                    if (allInformationThisUserAfterSearch.stAttempt > 0)
                    {
                        allInformationThisUserAfterSearch.stAttempt = 3;
                        showOverLayAfterClickLogIn();
                        MessageBox.Show($"Welcom {username} ");
                        UpdateInformationListStructure(allInformationThisUserAfterSearch, username);
                    }
                    else
                    {
                        MessageBox.Show("Lock Acc");
                    }
                }
                else
                {
                    if (allInformationThisUserAfterSearch.stAttempt > 0 )
                    {
                        allInformationThisUserAfterSearch.stAttempt--;
                        UpdateInformationListStructure(allInformationThisUserAfterSearch, username);
                    }
                    else
                    {
                        MessageBox.Show("Lock Acc");
                    }
                }

            }
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
            LogInVMS();

        }

    
    }
}
