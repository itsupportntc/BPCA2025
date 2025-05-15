using System.Data;

namespace CondoDeficiencyReports
{
    public partial class BPCAnvoiceAllocatedAdjustments : GrapeCity.ActiveReports.SectionReport
    {
        DataTable _dt;
        public BPCAnvoiceAllocatedAdjustments(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
            DataSource = _dt;
        }
    }
}
