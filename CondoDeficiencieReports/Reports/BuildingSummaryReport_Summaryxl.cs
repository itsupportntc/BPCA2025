using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for BuildingSummaryReport_Summary.
    /// </summary>
    public partial class BuildingSummaryReport_Summaryxl : GrapeCity.ActiveReports.SectionReport
    {
        DataTable _hdrData;
        DataTable _dtlData;
        public BuildingSummaryReport_Summaryxl(DataTable hdrData, DataTable dtlData)
        {
            InitializeComponent();
            _hdrData = hdrData;
            DataSource = dtlData;
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            //textBuildingAddress.Text = _hdrData.Rows[0]["Building"].ToString();
            //textAgencyAddress.Text = _hdrData.Rows[0]["agency"].ToString();
            //labelHeader.Text = string.Format(labelHeader.Text, ((DateTime)_hdrData.Rows[0]["asof"]).ToShortDateString());
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
            
        }

        private void BuildingSummaryReport_Summary_ReportEnd(object sender, EventArgs e)
        {
           
        }

        private void pageFooter_BeforePrint(object sender, EventArgs e)
        {
            if (int.Parse(rptInfoPageNumber.Text) == int.Parse(rptInfoPageCount.Text))
            {
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;
            }
        }

        private void groupFooter1_BeforePrint(object sender, EventArgs e)
        {
            if (int.Parse(pgNum.Text) != int.Parse(pgCount.Text))
            {
                groupFooter1.Visible = false;
            }
            else
            {
                groupFooter1.Visible = true;
            }
        }
    }
}
