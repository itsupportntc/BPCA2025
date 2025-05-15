using System;
using System.Data;
using System.Globalization;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport.
    /// </summary>
    public partial class DeficiencyReport : GrapeCity.ActiveReports.SectionReport
    {
        DataSet _ds;
        bool _isOld;
        public DeficiencyReport(DataSet ds,bool isOld)
        {
            InitializeComponent();
            _ds = ds;
            _isOld = isOld;
            DataSource = _ds.Tables[1];
        }

        private void reportHeader1_Format(object sender, EventArgs e)
        {
            if(_ds.Tables[0].Rows.Count == 0) { return; }

            DataRow dr = _ds.Tables[0].Rows[0];

            textInvoiceDate.Text = DateTime.Parse(dr["invoiceDate"].ToString()).ToString("MMMM d, yyyy");
            labelAgencyName.Text = dr["agency"].ToString();
            labelBuildingName.Text = dr["buildingName"].ToString();
            labelInvBaseRent.Text = ((decimal)dr["baserent"]).ToString("c");
            labelInvCivic.Text = ((decimal)dr["civic"]).ToString("c");
            labelInvSupp.Text = ((decimal)dr["suppl"]).ToString("c");
            labelInvPilot.Text = ((decimal)dr["pilot"]).ToString("c");
            labelInvTotal.Text = ((decimal)dr["total"]).ToString("c");
        }

        private void DeficiencyReport_ReportEnd(object sender, EventArgs e)
        {
            if (_ds.Tables[3].Rows.Count > 0)
            {
                DeficiencyReport_PaybackSummary defPySum = new DeficiencyReport_PaybackSummary(_ds.Tables[3]);
                defPySum.Run();
                for (int i = 0; i < defPySum.Document.Pages.Count; i++)
                {
                    Document.Pages.Add(defPySum.Document.Pages[i]);
                }
                defPySum.Dispose();
            }

            if (_ds.Tables[11].Rows.Count > 0)
            {
                DeficiencyReport_PaybackSummaryNew defPySum = new DeficiencyReport_PaybackSummaryNew(_ds.Tables[11]);
                defPySum.Run();
                for (int i = 0; i < defPySum.Document.Pages.Count; i++)
                {
                    Document.Pages.Add(defPySum.Document.Pages[i]);
                }
                defPySum.Dispose();
            }

            if (_ds.Tables[4].Rows.Count > 0 && _ds.Tables[5].Rows.Count > 0)
            {
                DeficiencyReport_Paybacks defPay = new DeficiencyReport_Paybacks(_ds.Tables[4], _ds.Tables[5]);
                defPay.Run();
                for (int i = 0; i < defPay.Document.Pages.Count; i++)
                {
                    Document.Pages.Add(defPay.Document.Pages[i]);
                }
                defPay.Dispose();
            }
            if (_ds.Tables[9].Rows.Count > 0)
            {
                DeficiencyReport_RollbackDetailSummary defRBDetSum = new DeficiencyReport_RollbackDetailSummary(_ds.Tables[9]);
                defRBDetSum.Run();
                for (int i = 0; i < defRBDetSum.Document.Pages.Count; i++)
                {
                    Document.Pages.Add(defRBDetSum.Document.Pages[i]);
                }
                defRBDetSum.Dispose();
            }
            if (_ds.Tables[2].Rows.Count > 0)
            {
                DeficiencyReport_PilotAdjDetails defPyAdj = new DeficiencyReport_PilotAdjDetails(_ds.Tables[2]);
                defPyAdj.Run();
                for (int i = 0; i < defPyAdj.Document.Pages.Count; i++)
                {
                    Document.Pages.Add(defPyAdj.Document.Pages[i]);
                }
                defPyAdj.Dispose();
            }

            if (!_isOld)
            {
                if (_ds.Tables[8].Rows.Count > 0)
                {
                    DeficiencyReport_Cover defCover = new DeficiencyReport_Cover(_ds.Tables[0], _ds.Tables[8], _ds.Tables[12]);
                    defCover.Run();
                    for (int i = 0; i < defCover.Document.Pages.Count; i++)
                    {
                        Document.Pages.Insert(0, defCover.Document.Pages[i]);
                    }
                    defCover.Dispose();
                }
            }
            else
            {
                if (_ds.Tables[8].Rows.Count > 0)
                {
                    DeficiencyReport_CoverOld defCover = new DeficiencyReport_CoverOld(_ds.Tables[0], _ds.Tables[8], _ds.Tables[12]);
                    defCover.Run();
                    for (int i = 0; i < defCover.Document.Pages.Count; i++)
                    {
                        Document.Pages.Insert(0, defCover.Document.Pages[i]);
                    }
                    defCover.Dispose();
                }
            }

        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            decimal invTotal = decimal.Parse(labelInvTotal.Text, NumberStyles.Any);

            decimal defTotal = 0m;
            if (_ds.Tables[1].Rows.Count > 0)
            {
                defTotal = ((decimal)_ds.Tables[1].Compute("SUM(Total)", string.Empty) * -1);
            }

            decimal pybTotal = 0m;
            if (_ds.Tables[5].Rows.Count > 0)
            {
                pybTotal = (decimal)_ds.Tables[5].Compute("SUM(Total)", string.Empty);
            }

            decimal rbTotal = 0m;
            if(_ds.Tables[6].Rows.Count > 0)
            {
                rbTotal = (decimal)_ds.Tables[6].Compute("SUM(diffAmount)", string.Empty);
            }

            decimal rbDetailTotal = 0m;
            decimal rbGrandTotal = (rbTotal + rbDetailTotal);

            decimal invCredits = 0m;
            if(_ds.Tables[7].Rows.Count > 0)
            {
                invCredits = (decimal)_ds.Tables[7].Rows[0]["credits"];
            }

            decimal paybackReversalSum = 0m;
            if (_ds.Tables[10].Rows.Count > 0)
            {
                paybackReversalSum = (decimal)_ds.Tables[10].Rows[0]["total"];
            }

            textFooterInvoiceTotal.Text = invTotal.ToString("c");
            textFooterDefaultTotal.Text = defTotal.ToString("c");
            textFooterPaybackTotal.Text = pybTotal.ToString("c");
            textFooterRBTotalPerInv.Text = rbTotal.ToString("c");
            textFooterRBTotalDetail.Text = rbDetailTotal.ToString("c");
            textFooterRBGrandTotal.Text = rbGrandTotal.ToString("c");
            textFooterCredits.Text = invCredits.ToString("c");
            textPaybackReversalSum.Text = paybackReversalSum.ToString("c");

            textFooterBalanceDue.Text = (invTotal + defTotal + pybTotal + rbGrandTotal + invCredits + paybackReversalSum).ToString("c");

            if(!string.IsNullOrEmpty(textInvoiceDate.Text))
                paybackSubReport.Report = new DeficiencyReport_PaybackSubReport(DateTime.Parse(textInvoiceDate.Text), _ds.Tables[3]);

            rollbackSubReport.Report = new DeficiencyReport_RollbackSubReport(_ds.Tables[6]);

        }
    }
}
