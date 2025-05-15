using System;
using System.Data;
using System.Drawing;

namespace CondoDeficiencyReports
{
    public partial class DefaultCertificate : GrapeCity.ActiveReports.SectionReport
    {
        DataSet _ds;

        public DefaultCertificate()
        {
        }

        public DefaultCertificate(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            DataSource = _ds.Tables[1];
        }

        private void reportHeader1_Format(object sender, System.EventArgs e)
        {
            labelBuildingAddress.Text = _ds.Tables[0].Rows[0]["buildingFull"].ToString();
            labelDefCertFor.Text = string.Format(labelDefCertFor.Text, ((DateTime)_ds.Tables[0].Rows[0]["invoiceDate"]).ToString("MMMM yyyy"));
            labelVerbiage.Text = string.Format(labelVerbiage.Text, ((DateTime)_ds.Tables[0].Rows[0]["invoiceDate"]).ToString("MMMM yyyy"));
        }

        private void DefaultCertificate_ReportEnd(object sender, EventArgs e)
        {
            DefaultCertificateBreakdown rpt = new DefaultCertificateBreakdown(_ds);
            rpt.Run();

            for (int i = 0; i < rpt.Document.Pages.Count; i++)
            {
                Document.Pages.Add(rpt.Document.Pages[i]);
            }
        }
    }
}
