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
     
        public UserControlSectionDepartmentormSettings()
        {
            InitializeComponent();
        }
   
    
    }
}
