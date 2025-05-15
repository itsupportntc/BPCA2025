using System;
using System.Data;

namespace CondoDeficiencyReports
{
    public partial class BuildingSummary : GrapeCity.ActiveReports.SectionReport
    {
        private DataSet _ds;
        public BuildingSummary(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            DataSource = _ds.Tables[1];
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            textBuildingAddress.Text = _ds.Tables[0].Rows[0]["Building"].ToString();
            textAgencyAddress.Text = _ds.Tables[0].Rows[0]["agency"].ToString();
            labelHeader.Text = string.Format(labelHeader.Text, ((DateTime)_ds.Tables[0].Rows[0]["asof"]).ToShortDateString());
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            textBox18.Text = _ds.Tables[3].Rows[0]["baserenttotal"].ToString();
            textBox19.Text = _ds.Tables[3].Rows[0]["civictotal"].ToString();
            textBox20.Text = _ds.Tables[3].Rows[0]["supplementaltotal"].ToString();
            textBox21.Text = _ds.Tables[3].Rows[0]["pilottotal"].ToString();
            textBox22.Text = _ds.Tables[3].Rows[0]["totalSum"].ToString();
            textBox23.Text = _ds.Tables[3].Rows[0]["pilotadjtotal"].ToString();
            textBox24.Text = _ds.Tables[3].Rows[0]["adjtotalsum"].ToString();
        }

        private void BuildingSummary_ReportEnd(object sender, EventArgs e)
        {
            BuildingSummaryReport_Summary rpt = new BuildingSummaryReport_Summary(_ds.Tables[0], _ds.Tables[2]);
            rpt.Run();

            for (int i = 0; i < rpt.Document.Pages.Count; i++)
            {
                Document.Pages.Add(rpt.Document.Pages[i]);
            }
        }
    }
}
