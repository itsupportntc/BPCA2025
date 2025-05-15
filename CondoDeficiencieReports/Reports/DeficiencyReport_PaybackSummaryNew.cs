using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_PaybackSummary.
    /// </summary>
    public partial class DeficiencyReport_PaybackSummaryNew : GrapeCity.ActiveReports.SectionReport
    {
        public DeficiencyReport_PaybackSummaryNew(DataTable dt)
        {
            InitializeComponent();
            
            DataSource = dt;
        }
    }
}
