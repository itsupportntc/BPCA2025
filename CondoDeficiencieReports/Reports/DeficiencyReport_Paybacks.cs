using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_Paybacks.
    /// </summary>
    public partial class DeficiencyReport_Paybacks : GrapeCity.ActiveReports.SectionReport
    {
        DataTable _dtInv;
        DataTable _dtDet;
        public DeficiencyReport_Paybacks(DataTable dtInv, DataTable dtDet)
        {
            InitializeComponent();
            _dtInv = dtInv;
            _dtDet = dtDet;
            DataSource = _dtDet;
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            DataRow[] dr = _dtInv.Select(string.Format("InvoiceGuid = '{0}'", textInvoiceGuid.Text));

            if(dr.Length <= 0) { return; }

            textInvoiceDate.Text = DateTime.Parse(dr[0]["invoiceDate"].ToString()).ToString("MMMM d, yyyy");
            labelAgencyName.Text = dr[0]["agency"].ToString();
            labelBuildingName.Text = dr[0]["buildingName"].ToString();
            labelInvBaseRent.Text = ((decimal)dr[0]["baserent"]).ToString("c");
            labelInvCivic.Text = ((decimal)dr[0]["civic"]).ToString("c");
            labelInvSupp.Text = ((decimal)dr[0]["suppl"]).ToString("c");
            labelInvPilot.Text = ((decimal)dr[0]["pilot"]).ToString("c");
            labelInvTotal.Text = ((decimal)dr[0]["total"]).ToString("c");
            labelVerbiage.Text = string.Format(labelVerbiage.Text, DateTime.Parse(dr[0]["invoiceDate"].ToString()).ToString("MM/dd/yyyy"));
        }
    }
}
