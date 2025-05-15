using System;
using System.IO;
using GrapeCity.ActiveReports;
using System.Web;


namespace CondoDeficiencyReports
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
       {
            string rptType = HttpContext.Current.Request.QueryString["rt"];

            switch (rptType)
            {
                case "i":
                    WebViewer1.Report = GetInvoice(HttpContext.Current.Request.QueryString["ig"]);
                    break;
                case "ul":
                    WebViewer1.Report = GetUnitListing(HttpContext.Current.Request.QueryString["bg"]);
                    break;
                case "pfsl":
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=PaybacksByFicalYear.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                //Nazeema
                case "pfsl2023":
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetPaybacksByFicalYear2023(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetPaybacksByFicalYear2023(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=PaybacksByFicalYear.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "pfsl2024":
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetPaybacksByFicalYear2024(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetPaybacksByFicalYear2024(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=PaybacksByFicalYear.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "pfsl2025":
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    //WebViewer1.Report = GetPaybacksByFicalYear(HttpContext.Current.Request.QueryString["dt"]);
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetPaybacksByFicalYear2025(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetPaybacksByFicalYear2025(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=PaybacksByFicalYear.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "cdrd":
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetConsolidatedRentDetail(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetConsolidatedRentDetail(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=ConsRentDetail.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "cdrdfs":
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetConsolidatedRentDetailByFicalYear(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetConsolidatedRentDetailByFicalYear(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=ConsRentDetail.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;  
                case "cdrdfsData":
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetConsolidatedRentDataByFicalYear(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetConsolidatedRentDataByFicalYear(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=ConsRentDetail.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "cdad":
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetConsolidatedAgingDetail(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetConsolidatedAgingDetail(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=ConsAgingDetail.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;

                case "cdad3":
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetConsolidatedAgingDetail3(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    }
                    else
                    {
                        object rpt = GetConsolidatedAgingDetail3(HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=ConsAgingDetail.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "bs":
                    bool showSuspended = (HttpContext.Current.Request.QueryString["shsu"].ToString() != "true");
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetBuildingSummary(HttpContext.Current.Request.QueryString["bg"],
                            HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), showSuspended);
                    }
                    else
                    {
                        object rpt = GetBuildingSummaryxl(HttpContext.Current.Request.QueryString["bg"],
                            HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), showSuspended);

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX = 
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=BuildingSummary.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;

                case "bsv":
                    bool bsvshowSuspended = (HttpContext.Current.Request.QueryString["shsu"].ToString() != "true");
                    if (HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetBuildingSummaryVersionReport(HttpContext.Current.Request.QueryString["bg"],
                            HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), bsvshowSuspended);
                    }
                    else
                    {
                        object rpt = GetBuildingSummaryVersionReport(HttpContext.Current.Request.QueryString["bg"],
                            HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), bsvshowSuspended);

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=BuildingSummary.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    break;
                case "dc":
                    WebViewer1.Report = GetDefaultCertificate(HttpContext.Current.Request.QueryString["bg"],
                        HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    break;
                case "df":
                    bool isold = true;
                    if (HttpContext.Current.Request.QueryString["isold"] != null)
                    {
                        isold = Convert.ToBoolean((HttpContext.Current.Request.QueryString["isold"].ToString()));
                    }


                    if (HttpContext.Current.Request.QueryString["exc"] != null && HttpContext.Current.Request.QueryString["exc"].ToString() != "true")
                    {
                        WebViewer1.Report = GetDeficiencyReport(HttpContext.Current.Request.QueryString["bg"],
                       HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), isold);

                    }
                    else if (HttpContext.Current.Request.QueryString["exc"] != null)
                    {
                        object rpt = GetDeficiencyReport(HttpContext.Current.Request.QueryString["bg"],
                       HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), isold);

                        GrapeCity.ActiveReports.Export.Excel.Section.XlsExport xlsX =
                            new GrapeCity.ActiveReports.Export.Excel.Section.XlsExport();

                        MemoryStream msExcel = new MemoryStream();
                        (rpt as SectionReport).Run();
                        xlsX.Export((rpt as SectionReport).Document, msExcel);

                        msExcel.Seek(0, SeekOrigin.Begin);

                        Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        Response.AppendHeader("content-disposition", "attachment; filename=BuildingSummary.xls");

                        Response.OutputStream.Write(msExcel.ToArray(), 0, msExcel.ToArray().Length);
                        Response.Flush();
                        Response.Close();

                        msExcel.Dispose();
                        xlsX.Dispose();
                    }
                    else
                    {
                        WebViewer1.Report = GetDeficiencyReport(HttpContext.Current.Request.QueryString["bg"],
                             HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"), isold);
                    }
                   
                    break;
                case "dcr":
                    WebViewer1.Report = GetDeficiencyRollbackBreakdown(HttpContext.Current.Request.QueryString["bg"],
                        HttpContext.Current.Request.QueryString["dt"].ToString().Replace("%2F", "/"));
                    break;
                default:
                    break;
            }
        }

        private object GetDeficiencyReport(object buildingGuid, object asOf,bool isold)
        {
            return new DeficiencyReport(DataAccess.ExecuteDataSet("PrintDeficiencyReport", "@buildingGuid", buildingGuid, "@invoiceDate", asOf), isold);
        }

        private object GetDeficiencyRollbackBreakdown(object buildingGuid, object asOf)
        {
            return new DeficiencyReport_RollbackDetailBreakdown(DataAccess.ExecuteDataSet("PrintDeficiencyRollbackBreakdown", "@buildingGuid", buildingGuid, "@invoiceDate", asOf));
        }
        private object GetInvoice(object invoiceGuid)
        {
            return new BPCAInvoice(DataAccess.ExecuteDataSet("PrintInvoice", "@invoiceGuid", invoiceGuid));
        }
        
        private object GetUnitListing(object buildingGuid)
        {
            return new UnitListingReport(DataAccess.ExecuteDataSet("UnitListingReport", "@buildingGuid", buildingGuid));
        }

        private object GetDefaultCertificate(object buildingGuid, object asOf)
        {
            return new DefaultCertificate(DataAccess.ExecuteDataSet("PrintDefaultCertificate", "@buildingGuid", buildingGuid, "@invoiceDate", asOf));
        }

        private object GetBuildingSummary(object buildingGuid, object asOf, object showSuspended)
        {
            return new BuildingSummary(DataAccess.ExecuteDataSet("BuildingSummaryReport", "@buildingGuid", buildingGuid,
                "@asofdate", asOf, "@showSuspended", showSuspended));
        }

        private object GetBuildingSummaryxl(object buildingGuid, object asOf, object showSuspended)
        {
            return new BuildingSummaryxl(DataAccess.ExecuteDataSet("BuildingSummaryReport", "@buildingGuid", buildingGuid,
                "@asofdate", asOf, "@showSuspended", showSuspended));
        }

        private object GetBuildingSummaryVersionReport(object buildingGuid, object asOf, object showSuspended)
        {
          
            return new BuildingSummary_Version1(DataAccess.ExecuteDataSet("BuildingSummaryReportVersion1", "@buildingGuid", buildingGuid,
                "@asofdate", asOf, "@showSuspended", showSuspended));
        }

        private object GetConsolidatedRentDetail(object asOf)
        {
            return new ConsolidatedDeficienciesSummary_RentDetail(
                DataAccess.ExecuteDataTable("ConsolidatedDefaultsReport", "@asOfdate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }
        private object GetConsolidatedRentDetailByFicalYear(object asOf)
        {
            return new ConsolidatedDeficienciesSummary_RentDetailByFicalYear(
                DataAccess.ExecuteDataTable("ConsolidatedDefaultsReportforFicalYear", "@asOfdate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }

        private object GetConsolidatedRentDataByFicalYear(object asOf)
        {
            return new ConsolidatedDeficienciesSummary_RentDetailByFicalYearWithoutGrouping(
                DataAccess.ExecuteDataTable("ConsolidatedDefaultsReportforFicalYear", "@asOfdate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }
        private object GetPaybacksByFicalYear(object asOf)
        {
            return new DeficiencyReport_PaybackSummaryForFiscalYear(
                DataAccess.ExecuteDataTable("Sp_PaybackintoFiscalyear", "@invoiceDate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }
        private object GetPaybacksByFicalYear2023(object asOf)
        {
            return new DeficiencyReport_PaybackSummaryForFiscalYear2023(
                DataAccess.ExecuteDataTable("PaybackintoFiscalyear2023", "@invoiceDate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }
        private object GetPaybacksByFicalYear2024(object asOf)
        {
            return new DeficiencyReport_PaybackSummaryForFiscalYear2024(
                DataAccess.ExecuteDataTable("PaybackintoFiscalyear2024", "@invoiceDate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }
        private object GetPaybacksByFicalYear2025(object asOf)
        {
            return new DeficiencyReport_PaybackSummaryForFiscalYear2025(
                DataAccess.ExecuteDataTable("PaybackintoFiscalyear2025", "@invoiceDate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }
        private object GetConsolidatedAgingDetail(object asOf)
        {
            return new ConsolidatedDeficiencies_Aging(
                DataAccess.ExecuteDataTable("ConsolidatedDefaultsAgingReport", "@asOfdate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }

        private object GetConsolidatedAgingDetail3(object asOf)
        {
            return new ConsolidatedDeficiencies_AgingByYear(
                DataAccess.ExecuteDataTable("ConsolidatedDefaultsAgingReportbyYear", "@asOfdate", asOf),
                    DateTime.Parse(asOf.ToString()));
        }

        //private void GetExcel()
        //{
        //    Microsoft.Office.Interop.Excel.Application xlApp = new Application();
        //    Workbook wb = new Workbook();
        //    wb.Worksheets.Add()
        //}
    }
}