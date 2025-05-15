using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_PaybackSummary.
    /// </summary>
    public partial class DeficiencyReport_PaybackSummary : GrapeCity.ActiveReports.SectionReport
    {
        public DeficiencyReport_PaybackSummary(DataTable dt)
        {
            InitializeComponent();
            
            DataSource = dt;
        }
    }
}
