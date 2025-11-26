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


        private void ClearAllTextBoxInSectionDepartments ()
        {

            foreach(Control outterControl in this.Controls)
                if(outterControl is Guna2Panel G2P )
                    foreach(Control innerControls in G2P.Controls)
                        if(innerControls is SiticoneTextBoxAdvanced STBV)
                            STBV.Clear();

        }

        private void IntialSettingAfterLoadSectionDepartments()
        {
            ClearAllTextBoxInSectionDepartments(); 
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


   
        public UserControlSectionDepartmentormSettings()
        {
            InitializeComponent();
            LoadAllInformationDepartmentToDataGridViewDepartments();
            IntialSettingAfterLoadSectionDepartments();
        }

        private void GButtonClearFormAddNewDepartment_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxInSectionDepartments(); 
        }
    }
}
