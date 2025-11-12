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
    public partial class UserControlSectionDashboard : UserControl
    {

        //Constants
        private const System.String _kPATH_FILE_INFORMATION_VISITORS = @"../../Data_Information_VMS/Information_Visitors.txt";
        private const System.String _kSEPARATOR_FILE_INFORMATION_VISITORS = "++||++";
        private const System.Int16 _kNUMBER_START_READ_DATA_INFOMATION_VISITORS = 18;
        private const System.UInt16 _kNUMBER_MEMBER_INFORMATION_VISITOR = 6 ;
        private const System.UInt16 _kNUMBER_MEMBER_TO_SHOW_INFORMATION_VISITOR_IN_DGV = 7 ;
        private const System.UInt16 _MAX_HEIGHT_TO_INCREMENT_IN_HEIHT_LALBELS = 23 ;
        private const System.Int16 _kONE = 1;
        private const System.Int16 _kZERO = 0;


        private class stcInformationVisitors
        {

            public System.Int32 stcID; 
            public System.String stcFullNameVisitor;
            public System.String stcDepartment; 
            public System.String stcCheckInTimeVisitor; 
            public System.String stcPurpose ;
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
        
        private async void setAnimationLabelsInDashboard()
        {

            for(System.Int16 counterDelayAndIcrementHeight = _kZERO; counterDelayAndIcrementHeight < _MAX_HEIGHT_TO_INCREMENT_IN_HEIHT_LALBELS ; counterDelayAndIcrementHeight++)
            {
                await Task.Delay(counterDelayAndIcrementHeight  +  _kONE);
                labelNumberTotalVisitorsToday.Location = new Point(52, 103 + -counterDelayAndIcrementHeight);
                label4NumberCurrentInsideVisitors.Location = new Point(52, 103 + -counterDelayAndIcrementHeight);
                labelNumberCheckOutTodayVisitors.Location = new Point(52, 103 + -counterDelayAndIcrementHeight);
            
            }
        }
        
        private List<System.String> LoadAllInformationFromFile (System.String pathFile)
        {
            List<System.String> allLineInformationFromFile = new List<System.String>();

            System.String Line = null;

            if (!System.IO.File.Exists(pathFile))
                System.IO.File.Create(pathFile).Close();

            System.IO.StreamReader ReadAllLinesFromFile = new System.IO.StreamReader(pathFile); 

            while((Line = ReadAllLinesFromFile.ReadLine())!= null )
            {
                allLineInformationFromFile.Add(Line);
            }

            ReadAllLinesFromFile.Close();

            return allLineInformationFromFile; 

        }
   
        private stcInformationVisitors ConvertInformationlineToDataStrcture (List<System.String> lineInformationVisitor )
        {
            stcInformationVisitors informationOneVisitorStructure = new stcInformationVisitors();

            if (lineInformationVisitor.Count >= _kNUMBER_MEMBER_INFORMATION_VISITOR)
            {
                informationOneVisitorStructure.stcID = Convert.ToInt32(lineInformationVisitor[0]);
                informationOneVisitorStructure.stcFullNameVisitor = lineInformationVisitor[1];
                informationOneVisitorStructure.stcDepartment = lineInformationVisitor[2];
                informationOneVisitorStructure.stcCheckInTimeVisitor = lineInformationVisitor[3];
                informationOneVisitorStructure.stcPurpose = lineInformationVisitor[4];
                if(lineInformationVisitor[5] == "1")
                informationOneVisitorStructure.stcIsAvtiveVisitor = true;
                else informationOneVisitorStructure.stcIsAvtiveVisitor = false;
            }

            return informationOneVisitorStructure; 

        }
      
        private List<System.String> SplitLineInformation (System.String lineInformationVisitor , System.String Separator = "++||++")
        {
            List<System.String> allInformationLineAfterSplit = new List<System.String>();

            if (!System.String.IsNullOrEmpty(lineInformationVisitor))
            {
                allInformationLineAfterSplit.AddRange(lineInformationVisitor.Split(new System.String[] { Separator }, System.StringSplitOptions.RemoveEmptyEntries));
            }

            return allInformationLineAfterSplit;

        }

        private List<stcInformationVisitors> psuhAllInformationLiesAfterConvertToDataInListStructure (System.String pathFile ) 
        {
            List<System.String> allInformationLiesStringFromFile = LoadAllInformationFromFile(_kPATH_FILE_INFORMATION_VISITORS);
            List<stcInformationVisitors> allInformationDataVisitors = new List<stcInformationVisitors>(); 

            for (System.Int32 counter = _kNUMBER_START_READ_DATA_INFOMATION_VISITORS - _kONE ; counter < allInformationLiesStringFromFile.Count; counter++ )
            {
                List<System.String> allInformationOneLine = SplitLineInformation(allInformationLiesStringFromFile[counter], _kSEPARATOR_FILE_INFORMATION_VISITORS);

                if(allInformationOneLine.Count >= _kNUMBER_MEMBER_INFORMATION_VISITOR)
                    allInformationDataVisitors.Add(ConvertInformationlineToDataStrcture(allInformationOneLine));

            }

            return allInformationDataVisitors; 

        }

        private System.Boolean isActiveVisitor (System.Boolean valueActiveVisitor ) 
        {
            return (valueActiveVisitor);
        }

        private void PushAllInformationVisitorToDataGridView (System.String pathFile)
        {
            //Push Only 5 Visitor Current Visitor Restly Now 
            List<stcInformationVisitors> allInformationVisitors = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            System.Int16 countShowOnlySevenVisitorInDGV = _kONE; 

            for (System.Int32 counter = _kZERO ; counter < allInformationVisitors.Count; counter++)
            {
                if (countShowOnlySevenVisitorInDGV != _kNUMBER_MEMBER_TO_SHOW_INFORMATION_VISITOR_IN_DGV)
                {
                    if (isActiveVisitor(allInformationVisitors[counter].stcIsAvtiveVisitor))
                    {
                        DataGridViewCurrentlyActiveVisitors.Rows.Insert(_kZERO , allInformationVisitors[counter].stcFullNameVisitor, allInformationVisitors[counter].stcDepartment, allInformationVisitors[counter].stcCheckInTimeVisitor, allInformationVisitors[counter].stcPurpose);
                        ++countShowOnlySevenVisitorInDGV;
                    }
                }
                else
                    return; 
            }
        }

        private System.Int32 calcTotalCurrentInsideVisitors()
        {
            System.Int32 totalVisitors = _kZERO;

            List<stcInformationVisitors> allInformationVisitors = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            for (System.Int32 counter = _kZERO ; counter < allInformationVisitors.Count; counter++)
            {
                if (isActiveVisitor(allInformationVisitors[counter].stcIsAvtiveVisitor))  ++totalVisitors;
            }
            return totalVisitors;

        }
       
        private System.Int32 calcTotalVisitorsToday()
        {
            List<stcInformationVisitors> allInformationVisitors = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            return (allInformationVisitors.Count); 
        }

        private System.Int32 calcTotalVisitorsCheckOutToday()
        {
            System.Int32 totalCheckOutVisitorsToday = _kZERO;

            List<stcInformationVisitors> allInformationVisitors = psuhAllInformationLiesAfterConvertToDataInListStructure(_kPATH_FILE_INFORMATION_VISITORS);

            for (System.Int32 counter = _kZERO; counter < allInformationVisitors.Count; counter++)
            {
                if (!isActiveVisitor(allInformationVisitors[counter].stcIsAvtiveVisitor)) ++totalCheckOutVisitorsToday;
            }
            return totalCheckOutVisitorsToday;
        }

        public UserControlSectionDashboard() {

            InitializeComponent();

            PushAllInformationVisitorToDataGridView(_kPATH_FILE_INFORMATION_VISITORS);
            labelNumberTotalVisitorsToday.Text = Convert.ToString( calcTotalVisitorsToday());
            label4NumberCurrentInsideVisitors.Text = Convert.ToString(calcTotalCurrentInsideVisitors());
            labelNumberCheckOutTodayVisitors.Text = Convert.ToString(calcTotalVisitorsCheckOutToday());

            setAnimationLabelsInDashboard();
        }

       
    }
}
