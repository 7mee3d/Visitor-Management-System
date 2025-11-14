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
    public partial class UserControlSectionCheckOut : UserControl
    {
        public UserControlSectionCheckOut()
        {

            InitializeComponent();

        }

        //Constants
        private const System.String _kPATH_FILE_INFORMATION_VISITORS = @"../../Data_Information_VMS/Information_Visitors.txt";
        private const System.String _kSEPARATOR_FILE_INFORMATION_VISITORS = "++||++";
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

        private stcInformationVisitors returnEmptyObjectInformationVisitor()
        {
            return new stcInformationVisitors();
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

        private System.String ConvertDataInformationVisitorToLine(stcInformationVisitors informationOneVisitor, System.String Separator = "++||++")
        {
            System.String LineInformationVisitor = "";
            LineInformationVisitor += informationOneVisitor.stcID + Separator;
            LineInformationVisitor += informationOneVisitor.stcFullNameVisitor + Separator;
            LineInformationVisitor += informationOneVisitor.stcDepartment + Separator;
            LineInformationVisitor += informationOneVisitor.stcCheckInTimeVisitor + Separator;
            LineInformationVisitor += informationOneVisitor.stcPurpose + Separator;

            if (informationOneVisitor.stcIsAvtiveVisitor)
                LineInformationVisitor += "1";
            else
                LineInformationVisitor += "0";

            return LineInformationVisitor;
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

            for (System.Int32 counter = 0; counter < allInformationVisitors.Count; counter++)
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

        private void SaveAllInformationAfterChangeDataToFile(List<stcInformationVisitors> allInformationVisitorAfterChangeData, string pathFile)
        {
            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamWriter WriteAllInformationVisitorAfterChangeData = new System.IO.StreamWriter(pathFile);
            WriteAllInformationVisitorAfterChangeData.WriteLine(BannerInformationVisitor);

            foreach (stcInformationVisitors informationOneVisitor in allInformationVisitorAfterChangeData)
            {
                WriteAllInformationVisitorAfterChangeData.WriteLine(ConvertDataInformationVisitorToLine(informationOneVisitor, "++||++"));
            }
            WriteAllInformationVisitorAfterChangeData.Close();

        }

        private void UserControlSectionCheckOut_Load(object sender, EventArgs e)
        {
            PushAllInformationVisitorToDataGridView(_kPATH_FILE_INFORMATION_VISITORS);
        }

        private System.Boolean areEqualString(System.String StringOne, System.String StringTwo)
        {
            return (StringOne == StringTwo);
        }

        /*  private System.Int32 returnIDVisitorAfterFoundInFiles (System.String nameVisitor)
          {
              List<stcInformationVisitors> allInformationVisitor = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS); 

              foreach (stcInformationVisitors informationOneVisitor in allInformationVisitor)
              {
                  if (areEqualString(informationOneVisitor.stcFullNameVisitor, nameVisitor))
                      return informationOneVisitor.stcID; 
              }

              return 0; 
          }
          */

        private stcInformationVisitors searchTheVisitorInFiles(System.String IDVisitor)
        {
            List<stcInformationVisitors> allInformationVisitor = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            foreach (stcInformationVisitors informationOneVisitor in allInformationVisitor)
            {
                if (IDVisitor == informationOneVisitor.stcID.ToString())
                    return informationOneVisitor;
            }
            return returnEmptyObjectInformationVisitor();
        }

        private void ChangeActiveVisitioToCheckOut(ref stcInformationVisitors informationVisitor)
        {
            informationVisitor.stcIsAvtiveVisitor = false;
        }

        private void UpdateInformationVisitorAfterFound(ref stcInformationVisitors informationVisitor, System.String IDVisitor)
        {

            List<stcInformationVisitors> allInformationVisitor = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            for (int counter = 0; counter < allInformationVisitor.Count; counter++)
            {

                if (IDVisitor == allInformationVisitor[counter].stcID.ToString())
                {
                    allInformationVisitor[counter] = informationVisitor;
                    SaveAllInformationAfterChangeDataToFile(allInformationVisitor, _kPATH_FILE_INFORMATION_VISITORS);
                    return;
                }
            }


        }

        private async void ShowMessageSsuccessfullyCheckOutVisitor()
        {
            labelShowMessageAfterCheckOutVisitor.Text = "Check-out completed successfully.";
            await Task.Delay(5000);
            labelShowMessageAfterCheckOutVisitor.Text = "";

        }
     
        private void checkOutOneVisitor(DataGridViewRow RowInformationVisitor)
        {
            if (DataGridViewCurrentlyActiveVisitors.SelectedRows.Count > 0)
            {
                DataGridViewRow DGVR = RowInformationVisitor;

                string IDVisitor = DGVR.Cells[0].Value.ToString();
                stcInformationVisitors InformationVisitor = searchTheVisitorInFiles(IDVisitor);
                ChangeActiveVisitioToCheckOut(ref InformationVisitor);

                UpdateInformationVisitorAfterFound(ref InformationVisitor, IDVisitor);
                ShowMessageSsuccessfullyCheckOutVisitor();
            }
        }

        private void checkOutAllVisitorAfterSeleted()
        {
            foreach (DataGridViewRow RowInformationVisitor in DataGridViewCurrentlyActiveVisitors.SelectedRows) checkOutOneVisitor(RowInformationVisitor);

        }

        private void CheckOutVisitor()
        {
            checkOutAllVisitorAfterSeleted();
        }

        private void GGButtonCheckOutSelectedVisitor_Click(object sender, EventArgs e)
        {
            CheckOutVisitor();

        }

        private void ClearAllData_DataGridView()
        {
            DataGridViewCurrentlyActiveVisitors.Rows.Clear();
        }

        private void pushOneInformationVisitorToDataGridView(stcInformationVisitors informationOneVisitor)
        {
            List<System.String> informationVisitorCheckInDateAndTime = SplitLineInformation(informationOneVisitor.stcCheckInTimeVisitor, " , ");

            DataGridViewCurrentlyActiveVisitors.Rows.Add(
                informationOneVisitor.stcID,
                informationOneVisitor.stcFullNameVisitor,
                informationOneVisitor.stcDepartment,
                informationVisitorCheckInDateAndTime[1],
                informationOneVisitor.stcPurpose
                );
        }

        private System.Boolean isContainTextID(string IDVisitor, System.String ID)
        {
            return (IDVisitor.Contains(ID));
        }

        private System.Boolean isContainTextNameVisitor(string NameVisitor, System.String NameV)
        {
            return (NameVisitor.ToLower().Contains(NameV.ToLower()));
        }

        private System.Boolean IsContainIDorNameInFile(string TextToBeSearchIDorNameVisitor, string IDVisitor, string FullNameVisitor)
        {
            return (isContainTextID(IDVisitor.ToString(), TextToBeSearchIDorNameVisitor) || isContainTextNameVisitor(FullNameVisitor, TextToBeSearchIDorNameVisitor));
        }

        private void pushAllInformationAccordingSearch()
        {
            string TextToBeSearchIDorNameVisitor = sTextBoxSearch.Text.ToLower();

            List<stcInformationVisitors> allInformationVisitor = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            foreach (stcInformationVisitors informationOneVisitor in allInformationVisitor)
                if (informationOneVisitor.stcIsAvtiveVisitor)
                    if (IsContainIDorNameInFile(TextToBeSearchIDorNameVisitor, informationOneVisitor.stcID.ToString(), informationOneVisitor.stcFullNameVisitor))
                        pushOneInformationVisitorToDataGridView(informationOneVisitor);


        }

        private void SearchVisitorInVMS()
        {
            ClearAllData_DataGridView();
            pushAllInformationAccordingSearch();
        }

        private void GGButtonSearchVisitor_Click(object sender, EventArgs e)
        {
            SearchVisitorInVMS();
        }

        private void setDefaultDataGridViewAndTextBoxSearch()
        {

            PushAllInformationVisitorToDataGridView(_kPATH_FILE_INFORMATION_VISITORS);
            sTextBoxSearch.Clear();
            sTextBoxSearch.Focus();

        }

        private void sTextBoxSearch_Click(object sender, EventArgs e)
        {
            setDefaultDataGridViewAndTextBoxSearch();

        }

        private void checkOutSelectedVisitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewCurrentlyActiveVisitors.SelectedRows.Count > 0)
                CheckOutVisitor();

        }
   
    }
}
