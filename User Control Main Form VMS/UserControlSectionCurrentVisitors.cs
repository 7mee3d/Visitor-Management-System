using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Management_System.User_Control_VMS
{
    public partial class UserControlSectionCurrentVisitors : UserControl
    {
        public UserControlSectionCurrentVisitors()
        {
            InitializeComponent();
            PushAllInformationVisitorToDataGridView(_kPATH_FILE_INFORMATION_VISITORS);
        }


        //Constants
        private const System.String _kPATH_FILE_INFORMATION_VISITORS = @"../../Data_Information_VMS/Information_Visitors.txt";
        private const System.String _kSEPARATOR_FILE_INFORMATION_VISITORS = "++||++";
        private const System.String _kSEPARATOR_FIELD_CHECK_OUT_VISITOR_DATE_AND_TIME = " , ";
        private const System.Int16 _kNUMBER_START_READ_DATA_INFOMATION_VISITORS = 19;
        private const System.UInt16 _kNUMBER_MEMBER_INFORMATION_VISITOR = 6;
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
        private void ClearAllData_DataGridView()
        {
            DataGridViewCurrentlyActiveVisitors.Rows.Clear();
        }

        private List<System.String> LoadAllInformationFromFile(System.String pathFile)
        {
            List<System.String> allLineInformationFromFile = new List<System.String>();

            System.String Line = null;

            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamReader ReadAllLinesFromFile = new System.IO.StreamReader(pathFile);

            while ((Line = ReadAllLinesFromFile.ReadLine()) != null)
            {
                allLineInformationFromFile.Add(Line);
            }

            ReadAllLinesFromFile.Close();

            return allLineInformationFromFile;

        }
       
        private stcInformationVisitors ConvertInformationlineToDataStrcture(List<System.String> lineInformationVisitor)
        {
            stcInformationVisitors informationOneVisitorStructure = new stcInformationVisitors();

            if (lineInformationVisitor.Count >= _kNUMBER_MEMBER_INFORMATION_VISITOR)
            {
                informationOneVisitorStructure.stcID = Convert.ToUInt64(lineInformationVisitor[0]);
                informationOneVisitorStructure.stcFullNameVisitor = lineInformationVisitor[1];
                informationOneVisitorStructure.stcDepartment = lineInformationVisitor[2];
                informationOneVisitorStructure.stcCheckInTimeVisitor = lineInformationVisitor[3];
                informationOneVisitorStructure.stcPurpose = lineInformationVisitor[4];

                if (lineInformationVisitor[5] == "1")
                    informationOneVisitorStructure.stcIsAvtiveVisitor = true;
                else informationOneVisitorStructure.stcIsAvtiveVisitor = false;
            }

            return informationOneVisitorStructure;

        }

        private List<System.String> SplitLineInformation(System.String lineInformationVisitor, System.String Separator = "++||++")
        {
            List<System.String> allInformationLineAfterSplit = new List<System.String>();

            if (!System.String.IsNullOrEmpty(lineInformationVisitor))
                allInformationLineAfterSplit.AddRange(lineInformationVisitor.Split(new System.String[] { Separator }, System.StringSplitOptions.RemoveEmptyEntries));

            return allInformationLineAfterSplit;

        }

        private List<stcInformationVisitors> psuhAllInformationLiesAfterConvertToDataInListStructure(System.String pathFile)
        {
            List<System.String> allInformationLiesStringFromFile = LoadAllInformationFromFile(_kPATH_FILE_INFORMATION_VISITORS);
            List<stcInformationVisitors> allInformationDataVisitors = new List<stcInformationVisitors>();

            for (System.Int32 counter = _kNUMBER_START_READ_DATA_INFOMATION_VISITORS - _kONE; counter < allInformationLiesStringFromFile.Count; counter++)
            {

                List<System.String> allInformationOneLine = SplitLineInformation(allInformationLiesStringFromFile[counter], _kSEPARATOR_FILE_INFORMATION_VISITORS);

                if (allInformationOneLine.Count >= _kNUMBER_MEMBER_INFORMATION_VISITOR)
                    allInformationDataVisitors.Add(ConvertInformationlineToDataStrcture(allInformationOneLine));

            }

            return allInformationDataVisitors;

        }

        private System.Boolean isActiveVisitor(System.Boolean valueActiveVisitor)
        {
            return (valueActiveVisitor);
        }

        private void PushAllInformationVisitorToDataGridView(System.String pathFile)
        {

            List<stcInformationVisitors> allInformationVisitors = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            for (System.Int32 counter = _kZERO; counter < allInformationVisitors.Count; counter++)
            {

                if (isActiveVisitor(allInformationVisitors[allInformationVisitors.Count - counter - _kONE].stcIsAvtiveVisitor))
                {
                    List<System.String> informationCheckInVisitorDataAndTime = SplitLineInformation(allInformationVisitors[allInformationVisitors.Count - counter - _kONE].stcCheckInTimeVisitor, " , ");

                    DataGridViewCurrentlyActiveVisitors.Rows.Add
                        (
                        allInformationVisitors[allInformationVisitors.Count - counter - _kONE].stcID,
                         allInformationVisitors[allInformationVisitors.Count - counter - _kONE].stcFullNameVisitor
                        , allInformationVisitors[allInformationVisitors.Count - counter - _kONE].stcDepartment
                        , informationCheckInVisitorDataAndTime[_kONE]
                        , allInformationVisitors[allInformationVisitors.Count - counter - _kONE].stcPurpose
                        );


                }
            }


        }
       
        private System.Boolean isContainTextInAnotherTextOrNot (System.String TextOne , System.String TextTwo )
        {
            return (TextOne.ToLower().Contains(TextTwo.ToLower()));
        }

        private List<stcInformationVisitors> LoadAllInformationVisitorAccordingTextSearch(System.String TextSearchInCurrentVisitors )
        {
            List<stcInformationVisitors> allInformationVisitors = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);
            List<stcInformationVisitors> allInformationVisitorSameDetailsTextSearch  = new List<stcInformationVisitors>() ;

            foreach(stcInformationVisitors informationOneVisitor in allInformationVisitors)
            {
                if (isContainTextInAnotherTextOrNot(informationOneVisitor.stcID.ToString(), TextSearchInCurrentVisitors) || isContainTextInAnotherTextOrNot(informationOneVisitor.stcFullNameVisitor, TextSearchInCurrentVisitors))
                    allInformationVisitorSameDetailsTextSearch.Add(informationOneVisitor);
            }
            return allInformationVisitorSameDetailsTextSearch; 

        }
    
        private void PushAllInformationVisitorToSameOrContainTextSearch(System.String TextSearchInCurrentVisitors)
        {

            List<stcInformationVisitors> allInformationVisitorSameDetailsTextSearch = LoadAllInformationVisitorAccordingTextSearch(TextSearchInCurrentVisitors);
      
             foreach (stcInformationVisitors informationOneVisitor in allInformationVisitorSameDetailsTextSearch)
            {

                List<System.String> informationCheckOutVisitorDateAndTime = SplitLineInformation(informationOneVisitor.stcCheckInTimeVisitor, _kSEPARATOR_FIELD_CHECK_OUT_VISITOR_DATE_AND_TIME);
           
                DataGridViewCurrentlyActiveVisitors.Rows.Add(

                    informationOneVisitor.stcID,
                    informationOneVisitor.stcFullNameVisitor,
                    informationOneVisitor.stcDepartment,
                    informationCheckOutVisitorDateAndTime[1],
                    informationOneVisitor.stcPurpose

                    );
          
            }

        }
      
        private void SearchVisitorAccordingTextBoxSearch()
        {
            System.String OnformationVisitorToBeSearch = sTextBoxSearch.Text.Trim();
            PushAllInformationVisitorToSameOrContainTextSearch(OnformationVisitorToBeSearch);
        }

        private void SearchVisitor()
        {
            SearchVisitorAccordingTextBoxSearch();
        }
      
        private void ChangeAndRefershDataInDataGridViewErveryWriteTextBox()
        {
            ClearAllData_DataGridView();
            SearchVisitor();
        }
   
        private void sTextBoxSearch_TextContentChanged(object sender, EventArgs e)
        {
            ChangeAndRefershDataInDataGridViewErveryWriteTextBox();
        }

        private void setDefaultPropertiesControls()
        {

            sTextBoxSearch.Clear();
            ClearAllData_DataGridView();
            PushAllInformationVisitorToDataGridView(_kPATH_FILE_INFORMATION_VISITORS);

        }
     
        private void Refresh()
        {
            setDefaultPropertiesControls();
        }

        private void GGButtonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

     
    }
}
