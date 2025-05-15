using System.Data;

namespace CondoDeficiencyReports
{
    public partial class UnitListingReport : GrapeCity.ActiveReports.SectionReport
    {
        DataSet _ds;
        public UnitListingReport(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            DataSource = _ds.Tables[1];
        }

        private void reportHeader1_Format(object sender, System.EventArgs e)
        {
            textBuildingAddress.Text = _ds.Tables[0].Rows[0]["BuildingAddress"].ToString();
        }
    }
}
