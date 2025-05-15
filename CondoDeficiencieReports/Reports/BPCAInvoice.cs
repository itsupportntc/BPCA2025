using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for BPCAInvoice.
    /// </summary>
    public partial class BPCAInvoice : GrapeCity.ActiveReports.SectionReport
    {
        private DataSet _ds;
        BPCAInvoiceAdjustments adj;

        public BPCAInvoice(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            DataSource = _ds.Tables[1];
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            textToAddress.Text = _ds.Tables[0].Rows[0]["AgencyTo"].ToString();
            textPrintDate.Text = DateTime.Now.ToShortDateString();
            textPaymentDate.Text = ((DateTime)_ds.Tables[0].Rows[0]["InvoiceDate"]).ToShortDateString();

            textInvoiceDate.Text = ((DateTime)_ds.Tables[0].Rows[0]["InvoiceDate"]).ToString("MMM yyyy") + " Invoice";
        }


        private void BPCAInvoice_ReportEnd(object sender, EventArgs e)
        {
            //if (adj != null)
            //{
            //    adj.Dispose();
            //    adj = null;
            //}
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            if (_ds == null) { return; }

            if (_ds.Tables.Count >= 3)
            {
                if (_ds.Tables[2].Rows.Count == 0 && (_ds.Tables.Count > 3 && _ds.Tables[3].Rows.Count == 0)) { return; }

                if (_ds.Tables.Count > 3)
                {
                    adj = new BPCAInvoiceAdjustments(_ds.Tables[2], _ds.Tables[3]);
                    subReport1.Report = adj;
                }
                else
                {
                    adj = new BPCAInvoiceAdjustments(_ds.Tables[2], null);
                    subReport1.Report = adj;
                }
            }

            decimal creditTotal = 0m;
            decimal creditBR = 0m;
            decimal creditCV = 0m;
            decimal creditSupp = 0m;
            decimal creditPilot = 0m;
            if (_ds.Tables[2].Rows.Count != 0)
            {
                creditBR += (decimal)_ds.Tables[2].Compute("SUM(BaseRent)", string.Empty);
            }
            if (_ds.Tables[2].Rows.Count != 0)
            {
                creditCV += (decimal)_ds.Tables[2].Compute("SUM(CivicFacility)", string.Empty);
            }
            if (_ds.Tables[2].Rows.Count != 0)
            {
                creditSupp += (decimal)_ds.Tables[2].Compute("SUM(Supplemental)", string.Empty);
            }
            if (_ds.Tables[2].Rows.Count != 0)
            {
                creditPilot += (decimal)_ds.Tables[2].Compute("SUM(PILOT)", string.Empty);
            }

            if (_ds.Tables[2].Rows.Count != 0)
            {
                creditTotal += (decimal)_ds.Tables[2].Compute("SUM(Amount)", string.Empty);
            }

            if (_ds.Tables.Count > 3 && _ds.Tables[3].Rows.Count != 0)
            {
                creditTotal += (decimal)_ds.Tables[3].Compute("SUM(Amount)", string.Empty);
            }
            textCreditSubTotal.Text = creditTotal.ToString("c");
            textGrandTotal.Text = (creditTotal + (decimal)_ds.Tables[1].Rows[0]["SubTotal"]).ToString("c");
            textBox15.Text = creditBR.ToString("c");
            textBox14.Text = creditCV.ToString("c");
            textBox13.Text = creditSupp.ToString("c");
            textBox12.Text = creditPilot.ToString("c");
        }
    }
}
