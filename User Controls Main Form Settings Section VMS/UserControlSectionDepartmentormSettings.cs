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

namespace Visitor_Management_System.User_Controls_Main_Form_Settings_Section_VMS
{
    public partial class UserControlSectionDepartmentormSettings : UserControl
    {

        private class stcInformationOneDepartment
        {
            public string NameDepartment;
            public string DescriptionDepartment;
            public bool StatusDepartment; 

            public stcInformationOneDepartment()
            {
                NameDepartment = "";
                DescriptionDepartment = "";
                StatusDepartment = false;
            }
        }

        private const string _kPATH_FILE_INFOAMTION_DEPARTMENTS = @"../../Data_Information_VMS/Information_Departments.txt";
        private const ushort _kNUMBER_TO_START_READ_FROM_FILE = 15;
        private const string _kSEPARATOR_FILE_INFOMATION_DEPARTMENTS = "&&&|||&&&";

        private void ClearAllInformationDepartmentsFromDataGridView()
        {
            sDataGridViewInformationDepartments.Rows.Clear();
        }

        private bool checkAllTextBoxFillOrNot (List<string> allInformationNewDepartmnet )
        {
            return (allInformationNewDepartmnet[0] == "" || allInformationNewDepartmnet[1] == ""); 
        }

        private async Task timerShowMessageAddNewDepartmnetSccuessfulyAsync()
        {
            labelShowMessageAddDepartmnetSuccessfully.ForeColor = Color.Green; 
            labelShowMessageAddDepartmnetSuccessfully.Visible = true; 
            labelShowMessageAddDepartmnetSuccessfully.Text = "Department added successfully.";

            await Task.Delay(3000);
            labelShowMessageAddDepartmnetSuccessfully.Visible = false ; 
        }
      
        private async Task timerShowMessageAlreadyTheTextBoxiesIsEmptyAsync()
        {
            labelShowMessageAddDepartmnetSuccessfully.ForeColor = Color.Red;
            labelShowMessageAddDepartmnetSuccessfully.Visible = true;

            labelShowMessageAddDepartmnetSuccessfully.Text = "The textboxes are already empty";
            await Task.Delay(3000);

            labelShowMessageAddDepartmnetSuccessfully.Visible = false;
        }

        private async Task timerShowMessageAddNewDepartmnetWarningFiledsEmptyAsync()
        {
            labelShowMessageAddDepartmnetSuccessfully.ForeColor = Color.Red; 
            labelShowMessageAddDepartmnetSuccessfully.Visible = true;
            labelShowMessageAddDepartmnetSuccessfully.Text = "Text fields cannot be empty";

            await Task.Delay(3000);
            labelShowMessageAddDepartmnetSuccessfully.Visible = false;
        }

        private async Task AnimationMessageAddNewDepartmnetSccussfully()
        {
            for(int counter = 0; counter < 20; counter++ )
            {
                await Task.Delay(counter + 1);
                labelShowMessageAddDepartmnetSuccessfully.Location = new Point(27, 616 - counter);
                 timerShowMessageAddNewDepartmnetSccuessfulyAsync();
            }
        }
    
        private async Task AnimationMessageClearFormAlreadyTheTextBoxiesIsEmpty()
        {
            for (int counter = 0; counter < 20; counter++)
            {
                await Task.Delay(counter + 1);
                labelShowMessageAddDepartmnetSuccessfully.Location = new Point(27, 616 - counter);
                timerShowMessageAlreadyTheTextBoxiesIsEmptyAsync();
            }
        }

        private async void AnimationMessageAddNewDepartmnetWarning()
        {
            for (int counter = 0; counter < 20; counter++)
            {
                await Task.Delay(counter + 1);
                labelShowMessageAddDepartmnetSuccessfully.Location = new Point(27, 616 - counter);
                 timerShowMessageAddNewDepartmnetWarningFiledsEmptyAsync();
            }
        }
     
        private void ClearAllTextBoxInSectionDepartments ()
        {

            foreach (Control outterControl in this.Controls)
            {
                if (outterControl is Guna2GradientPanel G2GP) {
                    
                    foreach (Control innerControls in G2GP.Controls)
                    {
                        if (innerControls is SiticoneTextBoxAdvanced STBA)
                            STBA.Clear();
                    }
                }
            }
        }

        private void IntialSettingAfterLoadSectionDepartments()
        {
            ClearAllTextBoxInSectionDepartments();
            sDataGridViewInformationDepartments.ClearSelection();
            NumberDepartmentsAfterAddNewDepartment();

        }

        private List<string> LoadAllLinesFromFileDepartments()
        {
            List<string> allInformationLinesFromFile = new List<string>();

            if (!System.IO.File.Exists(_kPATH_FILE_INFOAMTION_DEPARTMENTS))
                System.IO.File.Create(_kPATH_FILE_INFOAMTION_DEPARTMENTS).Close();

            System.IO.StreamReader ReadAllLinesFromFileInformationDepartments = new System.IO.StreamReader(_kPATH_FILE_INFOAMTION_DEPARTMENTS);

            string lineInformationDepartment = "";

            while((lineInformationDepartment = ReadAllLinesFromFileInformationDepartments.ReadLine())!= null)
                allInformationLinesFromFile.Add(lineInformationDepartment);
            

            ReadAllLinesFromFileInformationDepartments.Close();

            return allInformationLinesFromFile; 
        }

        private List<string> SplitLineInformationDepartment (string lineInformationDepartment )
        {
            List<string> allInformationDepartmentAfterSplitLine = new List<string>();

            if (!string.IsNullOrEmpty(lineInformationDepartment))
                allInformationDepartmentAfterSplitLine.AddRange(lineInformationDepartment.Split(new string[] { _kSEPARATOR_FILE_INFOMATION_DEPARTMENTS }, StringSplitOptions.RemoveEmptyEntries));

            return allInformationDepartmentAfterSplitLine; 
        }

        private stcInformationOneDepartment ConvertInformationLineToDataInformationDepartment (List<string> informationDepartmentLine )
        {
            stcInformationOneDepartment informationDepartmentStructure = new stcInformationOneDepartment();


            informationDepartmentStructure.NameDepartment = informationDepartmentLine[0];
            informationDepartmentStructure.DescriptionDepartment = informationDepartmentLine[1];

            bool statusDepartment = false;
            if (informationDepartmentLine[2] == "1")
                statusDepartment = true;

            informationDepartmentStructure.StatusDepartment = statusDepartment;

            return informationDepartmentStructure;
        }

        private string ConvertInformationNewDepartmnetToLine (List<string> informationNewDepartment , string Separator = "&&&|||&&&")
        {

            string LineInformationDepartment = "";

            LineInformationDepartment += informationNewDepartment[0] + Separator;
            LineInformationDepartment += informationNewDepartment[1] + Separator;
            LineInformationDepartment += Convert.ToString(1) ;

            return LineInformationDepartment; 
        }

        private string ReturnWordActiveOrNotDepartment (bool statusDepartment )
        {
            return (statusDepartment) ? "Active" : "Inactive";
        }

        private List<stcInformationOneDepartment> LoadAllInformationDepartmentsInSturcture ()
        {
            List<stcInformationOneDepartment> allInformationDepartments = new List<stcInformationOneDepartment>();
            List<string> allLinesInformationDepartmentsString = LoadAllLinesFromFileDepartments();

            for(int counter = _kNUMBER_TO_START_READ_FROM_FILE; counter < allLinesInformationDepartmentsString.Count; counter++)
                allInformationDepartments.Add(
                    ConvertInformationLineToDataInformationDepartment(
                        SplitLineInformationDepartment(
                            allLinesInformationDepartmentsString[counter])));
            

            return allInformationDepartments; 
        }

        private void LoadAllInformationDepartmentToDataGridViewDepartments()
        {

            List<stcInformationOneDepartment> allInformationDepartments = LoadAllInformationDepartmentsInSturcture();

            foreach (stcInformationOneDepartment informationOneDepartmnet in allInformationDepartments)
            {


                int rowIndex = sDataGridViewInformationDepartments.Rows.Add(
                         informationOneDepartmnet.NameDepartment,
                         informationOneDepartmnet.DescriptionDepartment,
                         ReturnWordActiveOrNotDepartment(informationOneDepartmnet.StatusDepartment)
                     );

                DataGridViewRow DGVR = sDataGridViewInformationDepartments.Rows[rowIndex];

                DataGridViewCell DGVC = DGVR.Cells[2];
                DGVC.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                if (informationOneDepartmnet.StatusDepartment)
                
                    DGVC.Style.ForeColor = Color.FromArgb(21, 128, 61);
                else   
                    DGVC.Style.ForeColor = Color.FromArgb(185, 28, 28);
                
            }

        }

        private List<string>allInformationNewDepartmentGetTheForm()
        {
            List<string> informationNewDepartmentList = new List<string>();
            string NameDepartment = sTextBoxDepartmentName.Text;
            string DiscriptionDepartment = sTextBoxDescriptionDepartment.Text;

            informationNewDepartmentList.Add(NameDepartment);
            informationNewDepartmentList.Add(DiscriptionDepartment);

            return informationNewDepartmentList;

        }
      
        private void SaveNewDepartmnetToFile(string LineInformationDepartment ) 
        {
            if (!System.IO.File.Exists(_kPATH_FILE_INFOAMTION_DEPARTMENTS))
                System.IO.File.Create(_kPATH_FILE_INFOAMTION_DEPARTMENTS).Close();

            System.IO.StreamWriter WriteNewDepartmentToFile = new System.IO.StreamWriter(_kPATH_FILE_INFOAMTION_DEPARTMENTS, true);

            WriteNewDepartmentToFile.WriteLine(LineInformationDepartment);

            WriteNewDepartmentToFile.Close(); 

        }
   
        private void RefreshInformationDepartmentsAfterAddNewDepartments()
        {
            ClearAllInformationDepartmentsFromDataGridView();
            LoadAllInformationDepartmentToDataGridViewDepartments();
            NumberDepartmentsAfterAddNewDepartment();
        }
      
        private async void SaveTheDepartmentInFileAfterEnterdTheInformationAsync ()
        {
            if (!checkAllTextBoxFillOrNot(allInformationNewDepartmentGetTheForm()))
            {
                string LineInformationDepartment = ConvertInformationNewDepartmnetToLine(allInformationNewDepartmentGetTheForm(), "&&&|||&&&");
                SaveNewDepartmnetToFile(LineInformationDepartment);
                IntialSettingAfterLoadSectionDepartments();
                AnimationMessageAddNewDepartmnetSccussfully();
                RefreshInformationDepartmentsAfterAddNewDepartments();
            }
            else
                 AnimationMessageAddNewDepartmnetWarning(); 
            
        }
  
        private void AddNewDepartmnet()
        {
            SaveTheDepartmentInFileAfterEnterdTheInformationAsync();
        }
   
        public UserControlSectionDepartmentormSettings()
        {
            InitializeComponent();
            LoadAllInformationDepartmentToDataGridViewDepartments();
            IntialSettingAfterLoadSectionDepartments();
        }

        private void ClearForm()
        {
            if (!checkAllTextBoxFillOrNot(allInformationNewDepartmentGetTheForm()))
                ClearAllTextBoxInSectionDepartments();
            else
                AnimationMessageClearFormAlreadyTheTextBoxiesIsEmpty();
        }

        private void GButtonClearFormAddNewDepartment_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void GButtonAddNewDepartment_Click(object sender, EventArgs e)
        {
            AddNewDepartmnet();
           
        }

        private void EnableButtonDeleteDepartmnetAfterSelect ()
        {
            if (sDataGridViewInformationDepartments.SelectedRows.Count > 0)
                GButtonDeleteDepartment.Enabled = true;
            else
                GButtonDeleteDepartment.Enabled = false; 
        }

        private void sDataGridViewInformationDepartments_SelectionChanged(object sender, EventArgs e)
        {
            EnableButtonDeleteDepartmnetAfterSelect();
        }
  
        private int returnNumberDepartments()
        {
            return (sDataGridViewInformationDepartments.Rows.Count);
        }
        
        private void NumberDepartmentsAfterAddNewDepartment()
        {
            labelNumberDepartments.Text = returnNumberDepartments().ToString();
        }
   
    }
}
