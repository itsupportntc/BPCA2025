using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for ConsolidatedDeficiencies_Aging.
    /// </summary>
    public partial class ConsolidatedDeficiencies_Aging : GrapeCity.ActiveReports.SectionReport
    {
        private DataTable _dt;
        private DateTime _asOf;
        public ConsolidatedDeficiencies_Aging(DataTable dt, DateTime asOf)
        {
            InitializeComponent();
            _dt = dt;
            _asOf = asOf;
            DataSource = _dt;
        }

        private void reportHeader1_Format(object sender, EventArgs e)
        {
            labelHeader.Text = labelHeader.Text + " " + _asOf.ToShortDateString();
        }
    }
}
