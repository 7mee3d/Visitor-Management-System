using Guna.UI2.WinForms;
using Siticone.Desktop.UI.WinForms;
using SiticoneNetFrameworkUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Management_System.User_Control_VMS
{
    public partial class UserControlSectionAddNewVisitor : UserControl
    {

        public UserControlSectionAddNewVisitor()
        {
            InitializeComponent();
        }


        //Constants
        private const System.String _kPATH_FILE_INFORMATION_VISITORS = @"../../Data_Information_VMS/Information_Visitors.txt";
        private const System.String _kSEPARATOR_FILE_INFORMATION_VISITORS = "++||++";
        private const System.Int16 _kNUMBER_START_READ_DATA_INFOMATION_VISITORS = 18;
        private const System.Int16 _kONE = 1;
        private const System.Int16 _kZERO = 0;

        string BannerInformationVisitor = @".--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--. 
/ .. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \
\ \/\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ \/ /
 \/ /`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'\/ / 
 / /\                                                                                                                / /\ 
/ /\ \        ___        __                            _   _              __     ___     _ _                        / /\ \
\ \/ /       |_ _|_ __  / _| ___  _ __ _ __ ___   __ _| |_(_) ___  _ __   \ \   / (_)___(_) |_ ___  _ __ ___        \ \/ /
 \/ /         | || '_ \| |_ / _ \| '__| '_ ` _ \ / _` | __| |/ _ \| '_ \   \ \ / /| / __| | __/ _ \| '__/ __|        \/ / 
 / /\         | || | | |  _| (_) | |  | | | | | | (_| | |_| | (_) | | | |   \ V / | \__ \ | || (_) | |  \__ \        / /\ 
/ /\ \       |___|_| |_|_|  \___/|_|  |_| |_| |_|\__,_|\__|_|\___/|_| |_|    \_/  |_|___/_|\__\___/|_|  |___/       / /\ \
\ \/ /                                                                                                              \ \/ /
 \/ /                                                                                                                \/ / 
 / /\.--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--./ /\ 
/ /\ \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \/\ \
\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `' /
 `--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--' 


";
        private class stcInformationVisitors
        {

            public System.UInt64 stcID;
            public System.String stcFullNameVisitor;
            public System.String stcDepartment;
            public System.String stcCheckInTimeVisitor;
            public System.String stcPurpose;
            public System.Boolean stcIsAvtiveVisitor;

            public stcInformationVisitors()
            {
                stcID = 0;
                stcFullNameVisitor = null;
                stcDepartment = null;
                stcCheckInTimeVisitor = null;
                stcPurpose = null;
                stcIsAvtiveVisitor = false;
            }


        }


        private void ClearAllTextBox_ResetAllOptions()
        {

            foreach (Control outterControl in this.Controls)
            {
                if (outterControl is Guna2Panel G2P)
                {
                    foreach (Control innerControl in G2P.Controls)
                    {
                        if (innerControl is Guna2Panel G2P_2)
                        {
                            foreach (Control innerInnerControl in G2P_2.Controls)
                            {
                                if (innerInnerControl is SiticoneTextBoxAdvanced STBA)
                                {
                                    if (STBA.Name == "sTextBoxCheckinTime")
                                    {
                                        STBA.Clear();
                                        STBA.Text = DateTimeNowCheckInVMSString();
                                    }
                                    else

                                        STBA.Clear();

                                }

                                if (innerInnerControl is SiticoneComboBox SCB)
                                {
                                    SCB.SelectedItem = "None";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InitialValueAfterLoadSectionAddNewVisitor()
        {
            sComboBoxDataDepartment.SelectedItem = "None";
            sTextBoxCheckinTime.Text = DateTimeNowCheckInVMSString();

        }


        private List<System.String> LoadAllLinesFromFile(System.String pathFile)
        {
            List<System.String> allLinesLoadingFromFile = new List<System.String>();

            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamReader ReadAllLinesFromFile = new System.IO.StreamReader(pathFile);

            System.String Line = null; 

            while ((Line = ReadAllLinesFromFile.ReadLine())!=null)
                allLinesLoadingFromFile.Add(Line);

            
            ReadAllLinesFromFile.Close(); 

            return allLinesLoadingFromFile;
        }

        private System.String ConvertDataToLineInformationVisitor (List<System.String> informationVisitorData, System.String Separator = "++||++")
        {
            System.String Line = "";
            Line += informationVisitorData[_kZERO] + Separator;
            Line += informationVisitorData[_kONE] + Separator;
            Line += informationVisitorData[_kONE + _kONE ] + Separator;
            Line += informationVisitorData[_kONE + _kONE + _kONE ] + Separator;
            Line += informationVisitorData[_kONE + _kONE + _kONE + _kONE] + Separator;
            Line += informationVisitorData[_kONE + _kONE + _kONE + _kONE + _kONE ];

            return Line;
        }
        
        private void LoadInformationNewVisitorToFile(System.String pathFile, System.String LineInformationNewVisitor )
        {

            List<System.String>  allLines = LoadAllLinesFromFile(pathFile);

            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamWriter WriteNewInformationVisitor = new System.IO.StreamWriter(pathFile, true);

          //  if((allLines.Count - _kNUMBER_START_READ_DATA_INFOMATION_VISITORS) >= 0 )
            if (!System.String.IsNullOrEmpty(LineInformationNewVisitor))
                WriteNewInformationVisitor.WriteLine(LineInformationNewVisitor);

            WriteNewInformationVisitor.Close();
        }
        
        private System.String ReturnStringWordComboBoxDepartment()
        {
            switch(sComboBoxDataDepartment.SelectedItem)
            {

                case "Reception":return "Reception";
                case "Security": return "Security";
                case "Sales": return "Sales"; 
                case "Support": return "Support"; 
                case "Human Resources": return "Human Resources"; 
                case "Management": return "Management";
                case "IT Department": return "IT Department"; 
                case "Maintenance": return "Maintenance"; 
                case "Marketing": return "Marketing"; 
                case "Finance": return "Finance"; 
                case "Operations": return "Operations"; 
                case "Customer Service": return "Customer Service"; 
                case "Research and Development": return "Research and Development"; 
                case "Logistics": return "Logistics"; 
                case "Legal": return "Legal"; 
                case "Administration": return "Administration"; 
                default:
                    return "NONE";
                  

            }
        }

        private string DateTimeNowCheckInVMSString()
        {
            System.String NowTimeCheckIn = DateTime.Now.ToString("dd/MM/yyyy , hh:mm:ss tt");
            return NowTimeCheckIn;
        }
     
        private void addNewVisitor ()
        {
            System.String IDVisitor = sTextBoxIDVisitor.Text; 
            System.String FullNameVisitor = sTextBoxFullNameVisitor.Text; 
            System.String Department = ReturnStringWordComboBoxDepartment();
            System.String checkTimeIN = sTextBoxCheckinTime.Text;
            System.String perpouse = sTextBoxPerpouse.Text;
            System.String activeAccount = "1";

            List<System.String> AllInformationNewVisitor = new List<System.String>();
            AllInformationNewVisitor.Add(IDVisitor);
            AllInformationNewVisitor.Add(FullNameVisitor);
            AllInformationNewVisitor.Add(Department);
            AllInformationNewVisitor.Add(checkTimeIN);
            AllInformationNewVisitor.Add(perpouse);
            AllInformationNewVisitor.Add(activeAccount);

            LoadInformationNewVisitorToFile(_kPATH_FILE_INFORMATION_VISITORS, ConvertDataToLineInformationVisitor (AllInformationNewVisitor , _kSEPARATOR_FILE_INFORMATION_VISITORS));



        }

        private async void setPropertiesMessageErrorAddNewVisitor()
        {
            labelErrorOrCorrectMessageAddNewVisitor.Text = "Please fill in all fields.";
            labelErrorOrCorrectMessageAddNewVisitor.ForeColor = Color.Red;
            labelErrorOrCorrectMessageAddNewVisitor.Visible = true;

            await Task.Delay(4000);
            labelErrorOrCorrectMessageAddNewVisitor.Visible = false;

        }
      
        private async void setPropertiesMessageCorrectAddNewVisitor()
        {
            labelErrorOrCorrectMessageAddNewVisitor.Text = "Visitor added successfully";
            labelErrorOrCorrectMessageAddNewVisitor.ForeColor = Color.Green;
            labelErrorOrCorrectMessageAddNewVisitor.Visible = true;

            await Task.Delay(4000);
            labelErrorOrCorrectMessageAddNewVisitor.Visible = false;

        }
        
        private void AddNewVisitorInSystemVMS()
        {
            if (!CheckAllFieldsAreFill())
            {
                addNewVisitor();
                setPropertiesMessageCorrectAddNewVisitor();
                ClearAllTextBox_ResetAllOptions();
            }
            else
                setPropertiesMessageErrorAddNewVisitor();


        }
     
        private void GGButtonAddNewVisitor_Click(object sender, EventArgs e)
        {
            AddNewVisitorInSystemVMS();
        }

        private void UserControlSectionAddNewVisitor_Load(object sender, EventArgs e)
        {
            InitialValueAfterLoadSectionAddNewVisitor();
        }

        private void GGButtonClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox_ResetAllOptions();
        }
    
        private System.Boolean CheckAllFieldsAreFill()
        {
            return (
                    sTextBoxFullNameVisitor.Text == "" ||
                    sTextBoxIDVisitor.Text == "" ||
                    sTextBoxPerpouse.Text == "" ||
                    sComboBoxDataDepartment.SelectedItem == "None"
                );
        }

       
    }
}
