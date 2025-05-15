using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_PaybackSummary.
    /// </summary>
    public partial class DeficiencyReport_PaybackSummaryForFiscalYear : GrapeCity.ActiveReports.SectionReport
    {
        private DateTime _asOf;
        public DeficiencyReport_PaybackSummaryForFiscalYear(DataTable dt, DateTime asOf)
        {
            InitializeComponent();
            
            DataSource = dt;
            _asOf = asOf;
        }
        private void reportHeader1_Format(object sender, EventArgs e)
        {
            if (label1.Text == "PAYBACK SUMMARY BY FISCAL YEAR THROUGH ")
            {
                label1.Text = label1.Text + "  " + _asOf.ToShortDateString();
            }
            else
            {
                label1.Text = string.Format(label1.Text, _asOf.ToShortDateString());
            }
           
            //label1.Text + "  " + _asOf.ToShortDateString();
        }
     
    }
}
