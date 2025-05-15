using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_RollbackSubReport.
    /// </summary>
    public partial class DeficiencyReport_RollbackSubReport : GrapeCity.ActiveReports.SectionReport
    {

        public DeficiencyReport_RollbackSubReport(DataTable dt)
        {
            InitializeComponent();
            DataSource = dt;
        }
    }
}
