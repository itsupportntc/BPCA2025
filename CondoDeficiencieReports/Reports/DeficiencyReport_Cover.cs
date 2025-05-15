using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_Cover.
    /// </summary>
    public partial class DeficiencyReport_Cover : GrapeCity.ActiveReports.SectionReport
    {
        private DataTable _headerDt;
        private DataTable _detailDt;
        private DataTable _detailTempDt;

        public DeficiencyReport_Cover(DataTable headerDt, DataTable detailDt, DataTable detailTempDt)
        {
            InitializeComponent();
            _headerDt = headerDt;
            _detailDt = detailDt;
            _detailTempDt = detailTempDt;
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            if (_headerDt.Rows.Count > 0)
            {
                DataRow dr = _headerDt.Rows[0];
                textInvoiceDate.Text = DateTime.Parse(dr["invoiceDate"].ToString()).ToString("MMMM d, yyyy");
                labelAgencyName.Text = dr["agencyname"].ToString();
                labelBuildingName.Text = dr["buildingName"].ToString();
            }
            if (_detailDt.Rows.Count > 0)
            {
                DataRow det_dr = _detailDt.Rows[0];
                Inv_BaseRent.Value = det_dr["Inv_BaseRent"];
                Inv_Civic.Value = det_dr["Inv_Civic"];
                Inv_Suppl.Value = det_dr["Inv_Suppl"];
                Inv_Pilot.Value = det_dr["Inv_Pilot"];
                Inv_Total.Value = det_dr["Inv_Total"];
                Def_BaseRent.Value = det_dr["Def_BaseRent"];
                Def_Civic.Value = det_dr["Def_Civic"];
                Def_Suppl.Value = det_dr["Def_Suppl"];
                Def_Pilot.Value = det_dr["Def_Pilot"];
                Def_Total.Value = det_dr["Def_Total"];
                Pay_BaseRent.Value = det_dr["Pay_BaseRent"];
                Pay_Civic.Value = det_dr["Pay_Civic"];
                Pay_Suppl.Value = det_dr["Pay_Suppl"];
                Pay_Pilot.Value = det_dr["Pay_Pilot"];
                Pay_Total.Value = det_dr["Pay_Total"];
                PilotAdj.Value = det_dr["PilotAdj"];
                PilotAdjTotal.Value = det_dr["PilotAdj"];
                Credits.Value = det_dr["Credits"];
                textBox7.Value = det_dr["CreditBR"];
                textBox6.Value = det_dr["CreditCF"];
                textBox5.Value = det_dr["CreditSupp"];
                textBox4.Value = det_dr["CreditPilot"];
                BalanceDue_BaseRent.Value = det_dr["BalanceDue_BaseRent"];
                BalanceDue_Civic.Value = det_dr["BalanceDue_Civic"];
                BalanceDue_Suppl.Value = det_dr["BalanceDue_Suppl"];
                BalanceDue_Pilot.Value = det_dr["BalanceDue_Pilot"];
                BalanceDue.Value = det_dr["BalanceDue"];
            }
            if(_detailTempDt.Rows.Count > 0) {
                DataRow det_dr = _detailTempDt.Rows[0];
                textBox8.Value = det_dr["Inv_BaseRent"];
                textBox9.Value = det_dr["Inv_Civic"];
                textBox10.Value = det_dr["Inv_Suppl"];
                textBox11.Value = det_dr["Inv_Pilot"];
                textBox12.Value = det_dr["Inv_Total"];
                textBox13.Value = det_dr["Def_BaseRent"];
                textBox14.Value = det_dr["Def_Civic"];
                textBox15.Value = det_dr["Def_Suppl"];
                textBox16.Value = det_dr["Def_Pilot"];
                textBox17.Value = det_dr["Def_Total"];
                textBox23.Value = det_dr["PilotAdj"];
                textBox30.Value = det_dr["PilotAdj"];
                textBox24.Value = det_dr["Credits"];
                textBox37.Value = det_dr["CreditBR"];
                textBox36.Value = det_dr["CreditCF"];
                textBox35.Value = det_dr["CreditSupp"];
                textBox34.Value = det_dr["CreditPilot"];
                textBox29.Value = det_dr["BalanceDue_BaseRent"];
                textBox28.Value = det_dr["BalanceDue_Civic"];
                textBox27.Value = det_dr["BalanceDue_Suppl"];
                textBox26.Value = det_dr["BalanceDue_Pilot"];
                textBox25.Value = det_dr["BalanceDue"];

                
            }
        }
    }
}
