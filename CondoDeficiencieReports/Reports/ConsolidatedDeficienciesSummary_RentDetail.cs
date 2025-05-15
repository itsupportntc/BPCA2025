using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for ConsolidatedDeficienciesSummary_RentDetail.
    /// </summary>
    public partial class ConsolidatedDeficienciesSummary_RentDetail : GrapeCity.ActiveReports.SectionReport
    {
        private DataTable _dt;
        private DateTime _asOf;
        public ConsolidatedDeficienciesSummary_RentDetail(DataTable dt, DateTime asOf)
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
