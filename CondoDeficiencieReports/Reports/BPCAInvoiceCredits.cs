using System.Data;

namespace CondoDeficiencyReports
{
  
    public partial class BPCAInvoiceCredits : GrapeCity.ActiveReports.SectionReport
    {
        public BPCAInvoiceCredits(DataTable dt)
        {
            InitializeComponent();
            DataSource = dt;
        }
    }
}
