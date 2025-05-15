using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_PaybackSubReport.
    /// </summary>
    public partial class DeficiencyReport_PaybackSubReport : GrapeCity.ActiveReports.SectionReport
    {
        DateTime _invDate;
        public DeficiencyReport_PaybackSubReport(DateTime invoiceDate, DataTable dt)
        {
            InitializeComponent();
            _invDate = invoiceDate;
            DataSource = dt;
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            labelPaybacksDue.Text = string.Format(labelPaybacksDue.Text, _invDate.ToString("MMM-yyyy"));
        }
    }
}

