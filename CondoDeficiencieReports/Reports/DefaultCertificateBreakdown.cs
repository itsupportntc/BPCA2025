using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DefaultCertificateBreakdown.
    /// </summary>
    public partial class DefaultCertificateBreakdown : GrapeCity.ActiveReports.SectionReport
    {
        DataSet _ds;
        public DefaultCertificateBreakdown(DataSet ds)
        {
            InitializeComponent();
            _ds = ds;
            DataSource = _ds.Tables[1];
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            labelBoardName.Text = string.Format(labelBoardName.Text, _ds.Tables[0].Rows[0]["buildingName"].ToString());
            //byte[] image = (byte[])_ds.Tables[0].Rows[0]["signature"];

            //if(image.Length > 0)
            //{
            //    MemoryStream ms = new MemoryStream(image);
            //    Bitmap ik = new Bitmap(ms);
            //    picture1.Image = ik;
            //}
         
        }
    }
}
