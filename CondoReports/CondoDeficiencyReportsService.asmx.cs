using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GrapeCity.ActiveReports;

namespace CondoReports
{
    /// <summary>
    /// Summary description for CondoDeficiencyReportsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CondoDeficiencyReportsService : GrapeCity.ActiveReports.Web.ReportService
    {


        [WebMethod(Description = "Returns a deficiency report.")]
        public byte[] GetDeficiencyReport()
        {

            Reports.DeficiencyReport rpt = new Reports.DeficiencyReport();
            rpt.Run();
            return rpt.Document.Content;
        }

        [WebMethod]
        protected override object OnCreateReportHandler(string reportPath)
        {
            Reports.DeficiencyReport rpt = new Reports.DeficiencyReport();
            rpt.Run();
            return rpt.Document.Content;

            //SectionReport rptOrders;

            //switch (reportPath)
            //{
            //    case "Reports/BillingInvoice.rdlx":
            //    case "Reports/Orders.rdlx":
            //        PageReport rptPageRDL = new PageReport();
            //        rptPageRDL.Load(new FileInfo(Server.MapPath(reportPath)));
            //        rptPageRDL.Report.DataSources[0].ConnectionProperties.ConnectString = "data source=" + Server.MapPath("~/App_Data/NWind.mdb") + ";provider=Microsoft.Jet.OLEDB.4.0;";
            //        return rptPageRDL;

            //    case "Reports/Invoice.rpx":

            //        rptOrders = new SectionReport();
            //        XmlTextReader xtr = new XmlTextReader(Server.MapPath(reportPath));
            //        rptOrders.LoadLayout(xtr);
            //        (rptOrders.DataSource as OleDBDataSource).ConnectionString = "data source=" + Server.MapPath("~/App_Data/NWind.mdb") + ";provider=Microsoft.Jet.OLEDB.4.0;";
            //        return rptOrders;
            //    default:
            //        return base.OnCreateReportHandler(reportPath);
            //}
        }
    }
}
