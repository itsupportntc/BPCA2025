using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for ConsolidatedDeficienciesSummary_RentDetail.
    /// </summary>
    public partial class ConsolidatedDeficienciesSummary_RentDetailByFicalYearWithoutGrouping : GrapeCity.ActiveReports.SectionReport
    {
        private DataTable _dt;
        private DateTime _asOf;
        private DateTime _startdate;
        public ConsolidatedDeficienciesSummary_RentDetailByFicalYearWithoutGrouping(DataTable dt, DateTime asOf)
        {
            InitializeComponent();
            _dt = dt;
            _asOf = asOf;
            DataSource = _dt;
            if (_dt.Rows[0]["StartDate"] != null) {
                _startdate = Convert.ToDateTime(_dt.Rows[0]["StartDate"]);
            }
        }

        private void reportHeader1_Format(object sender, EventArgs e)
        {
            labelHeader.Text = labelHeader.Text  + _startdate.ToShortDateString() + " to " + _asOf.ToShortDateString();
        }
    }
}
