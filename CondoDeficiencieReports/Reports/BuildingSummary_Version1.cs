using System;
using System.Data;

namespace CondoDeficiencyReports
{
    public partial class BuildingSummary_Version1 : GrapeCity.ActiveReports.SectionReport
    {
        private DataSet _ds;
       private DataTable _dt;
        public BuildingSummary_Version1(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            //if(_ds.Tables.Count == 4)
            //{
            //    DataSource = _ds.Tables[2];
            //}
            //else
            //{
            _dt = _ds.Tables[1];
                DataSource = _dt;
           // }
           
            //DataSource = _ds.Tables[2];
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            if(_ds.Tables[0].Columns.Count <= 1)
            {
                textBuildingAddress.Text = "";
                textAgencyAddress.Text = "";
                labelHeader.Text = string.Format(labelHeader.Text, ((DateTime)_ds.Tables[0].Rows[0]["asof"]).ToShortDateString());
            }
            else
            {
                textBuildingAddress.Text = _ds.Tables[0].Rows[0]["Building"].ToString();
                textAgencyAddress.Text = _ds.Tables[0].Rows[0]["agency"].ToString();
                labelHeader.Text = string.Format(labelHeader.Text, ((DateTime)_ds.Tables[0].Rows[0]["asof"]).ToShortDateString());
            }
            
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            //if(_ds.Tables.Count == 4)
            //{
            //    //textBox1.Text = _ds.Tables[2].Rows[0]["baserenttotal"].ToString();
            //    textBox15.Text = _ds.Tables[3].Rows[0]["baserenttotal"].ToString();
            //    textBox14.Text = _ds.Tables[3].Rows[0]["civictotal"].ToString();
            //    textBox13.Text = _ds.Tables[3].Rows[0]["supplementaltotal"].ToString();
            //    textBox12.Text = _ds.Tables[3].Rows[0]["pilottotal"].ToString();
            //    textBox11.Text = _ds.Tables[3].Rows[0]["totalSum"].ToString();
            //    textBox16.Text = _ds.Tables[3].Rows[0]["pilotadjtotal"].ToString();
            //    textBox17.Text = _ds.Tables[3].Rows[0]["adjtotalsum"].ToString();
            //}
            //else
            //{
                textBox27.Text = _ds.Tables[2].Rows[0]["monthcount"].ToString();
                textBox15.Text = _ds.Tables[2].Rows[0]["baserenttotal"].ToString();
                textBox14.Text = _ds.Tables[2].Rows[0]["civictotal"].ToString();
                textBox13.Text = _ds.Tables[2].Rows[0]["supplementaltotal"].ToString();
                textBox12.Text = _ds.Tables[2].Rows[0]["pilottotal"].ToString();
                textBox11.Text = _ds.Tables[2].Rows[0]["totalSum"].ToString();
                textBox16.Text = _ds.Tables[2].Rows[0]["pilotadjtotal"].ToString();
                textBox17.Text = _ds.Tables[2].Rows[0]["adjtotalsum"].ToString();
           // }
           
        }

        private void BuildingSummary_ReportEnd(object sender, EventArgs e)
        {
            //BuildingSummaryReport_Summary rpt = new BuildingSummaryReport_Summary(_ds.Tables[0], _ds.Tables[2]);
            //rpt.Run();

            //for (int i = 0; i < rpt.Document.Pages.Count; i++)
            //{
            //    Document.Pages.Add(rpt.Document.Pages[i]);
            //}
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            if (_ds.Tables.Count == 4)
            {
                groupFooter1.Visible = true;
               // textBox18.Text = _ds.Tables[1].Rows[0]["BuildingName"].ToString();

            }
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            if (_ds.Tables.Count == 4)
            {
                groupHeader1.Visible = true;
             // textBox18.Text = _ds.Tables[1].Rows[0]["BuildingName"].ToString();

           }
        }
    }
}
