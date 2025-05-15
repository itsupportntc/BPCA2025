using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_RollbackDetailSummary.
    /// </summary>
    public partial class DeficiencyReport_RollbackDetailBreakdown : GrapeCity.ActiveReports.SectionReport
    {
        decimal InvoiceTotal_amt = 0m;

        DataSet _ds;
        public DeficiencyReport_RollbackDetailBreakdown(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            DataSource = ds.Tables[2];
        }
        private void pageHeader_Format(object sender, EventArgs e)
        {
            if (_ds.Tables[0].Rows.Count > 0)
            {
                labelBuildingName.Text = _ds.Tables[0].Rows[0]["buildingName"].ToString();
                labelAgencyName.Text = _ds.Tables[0].Rows[0]["agencyname"].ToString();
                textInvoiceDate.Text = DateTime.Parse(_ds.Tables[0].Rows[0]["invoiceDate"].ToString()).ToString("MMMM d, yyyy");


            }

        }
        private void detail_Format(object sender, System.EventArgs e)
        {
            if (_ds.Tables[2].Rows.Count > 0)
            {
                if (textBox1.Text == "Latest Invoice Data")
                {
                    InvoiceTotal_amt += decimal.Parse(textBox8.Text, System.Globalization.NumberStyles.Any);

                }
                else
                {
                    InvoiceTotal_amt -= decimal.Parse(textBox8.Text, System.Globalization.NumberStyles.Any);

                }
            }
        }

        private void DeficiencyReport_ReportEnd(object sender, EventArgs e)
        {
            if (_ds.Tables[3].Rows.Count > 0)
            {
                DeficiencyReport_RollbackDetailDefaults defPydef = new DeficiencyReport_RollbackDetailDefaults(_ds.Tables[3]);
                defPydef.Run();
                for (int i = 0; i < defPydef.Document.Pages.Count; i++)
                {
                    Document.Pages.Add(defPydef.Document.Pages[i]);
                }
                defPydef.Dispose();
            }
        }
            private void groupFooter1_Format(object sender, System.EventArgs e)
        {

         
        }
        private void groupHeader1_Format(object sender, System.EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textInvoiceDate.Text))

                rollbackSubReport.Report = new DeficiencyReport_RollbackSubReport(_ds.Tables[1]);
            if (_ds.Tables[2].Rows.Count == 0) {
                label2.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label11.Visible = false;

            }
           
            }

        private void groupHeader2_Format(object sender, EventArgs e)
        {
            InvoiceTotal_amt = 0m;
        }

        private void groupFooter2_Format(object sender, EventArgs e)
        {

            textBox12.Value = InvoiceTotal_amt;
            if (_ds.Tables[2].Rows.Count == 0)
            {
                label12.Visible = false;
                textBox11.Visible = false;
                textBox13.Visible = false;
                line16.Visible = false;
                textBox12.Visible = false;
                line1.Visible = false;

            }
        }
    }
}
