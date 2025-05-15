using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for BPCAInvoiceAdjustments.
    /// </summary>
    public partial class BPCAInvoiceAdjustments : GrapeCity.ActiveReports.SectionReport
    {
        DataTable _adj;
        DataTable _cred;
        BPCAnvoiceAllocatedAdjustments rptAdj;
        BPCAInvoiceCredits rptCred;
        public BPCAInvoiceAdjustments(DataTable dtCredits, DataTable dtAdj)
        {
            InitializeComponent();
            if (dtAdj != null) { _adj = dtAdj; }
            if (dtCredits != null) { _cred = dtCredits; }
            
        }

        private void BPCAInvoiceAdjustments_ReportStart(object sender, System.EventArgs e)
        {
            if (_adj != null && _adj.Rows.Count > 0)
                rptAdj = new BPCAnvoiceAllocatedAdjustments(_adj);

            if (_cred != null && _cred.Rows.Count > 0)
                rptCred = new BPCAInvoiceCredits(_cred);
        }

        private void BPCAInvoiceAdjustments_ReportEnd(object sender, System.EventArgs e)
        {
            //if (rptAdj != null)
            //{
            //    rptAdj.Dispose();
            //    rptAdj = null;
            //}
            //if (rptCred != null)
            //{
            //    rptCred.Dispose();
            //    rptCred = null;
            //}
        }

        private void detail_Format(object sender, System.EventArgs e)
        {
            if(rptAdj != null)
                subReport1.Report = rptAdj;

            if (rptCred != null)
                subReport2.Report = rptCred;
        }
    }
}
