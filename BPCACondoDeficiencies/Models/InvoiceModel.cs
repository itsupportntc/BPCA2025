using System;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class InvoiceModel
    {

        public Guid InvoiceGuid { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal BaseRent { get; set; }
        public decimal CivicFacility { get; set; }
        public decimal Supplemental { get; set; }
        public decimal PILOT { get; set; }
        
        public InvoiceModel()
        { }

        public static JsonResult GetInvoiceCredits(Guid invoiceGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoiceCredits", "@invoiceGuid", invoiceGuid)));
        }
        public static JsonResult GetInvoiceApproved(Guid invoiceGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoiceApproved", "@invoiceGuid", invoiceGuid)));
        }
        public static JsonResult GetInvoiceComponentsList()
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoiceComponents")));
        }
        
        public static void DeleteInvoiceCredit(int rowId)
        {
            DataAccess.DataAccess.ExecuteDataTable("DeleteInvoiceCredit", "@rowId", rowId);
        }

        public static void DeleteRollback(int rollbackId)
        {
            DataAccess.DataAccess.ExecuteDataTable("DeleteInvoiceRollback", "@rollbackId", rollbackId);
        }

        public static JsonResult GetInvoiceRollbacks(Guid invoiceGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoiceRollbacks", "@invoiceGuid", invoiceGuid)));
        }

        public static JsonResult GetInvoiceCreditTypes()
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoiceCreditTypes")));
        }

        public static Guid InvoiceExists(Guid buildingGuid, DateTime invoiceDate)
        {
            object ig = DataAccess.DataAccess.ExecuteScalar(CommandType.Text, "Select dbo.GetInvoiceGuid(@buildingGuid, @invoiceDate)",
                "@buildingGuid", buildingGuid, "@invoiceDate", invoiceDate);

            if (ig == null)
                return Guid.Empty;
            else
                return new Guid(ig.ToString());
        }

        public static JsonResult GetInvoiceHeader(Guid invoiceGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoiceHeader", "@invoiceGuid", invoiceGuid)));
        }

        public static JsonResult SaveInvoice(Guid invoiceGuid, DateTime invoiceDate, decimal baseRent, decimal civic, decimal suppl, decimal pilot, Guid buildingGuid, Guid userGuid)
        {
            return new JsonResult(
                Utilities.DataTableToJSONWithJSONNet(
                    DataAccess.DataAccess.ExecuteDataTable("SaveInvoice",
                    "@invoiceGuid", invoiceGuid,
                    "@invoiceDate", invoiceDate,
                    "@baserent", baseRent,
                    "@civic", civic,
                    "@suppl", suppl,
                    "@pilot", pilot,
                    "@buildingGuid", buildingGuid,
                    "@userGuid", userGuid)));
        }

        public static void ClearInvoiceCredits(Guid invoiceGuid)
        {
            DataAccess.DataAccess.ExecuteNonQuery("ClearInvoiceCredits", "@invoiceGuid", invoiceGuid);
        }

        public static void SaveInvoiceCredit(Guid invoiceGuid, int creditId, decimal creditAmount, decimal BaseRent, decimal CivicFacility, decimal Supplemental, decimal pilot, string userDesc, DateTime? dateFrom, DateTime? dateTo)
        {
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                DataAccess.DataAccess.ExecuteNonQuery("SaveInvoiceCredit",
                    "@invoiceGuid", invoiceGuid,
                    "@creditId", creditId,
                    "@creditAmount", creditAmount,
                     "@baserent", BaseRent,
                      "@civicfacility", CivicFacility,
                       "@supplemental", Supplemental,
                        "@pilot", pilot,
                    "@userDescription", userDesc,
                    "@userDateFrom", dateFrom.Value,
                    "@userDateTo", dateTo.Value);
            }
            else
            {
                DataAccess.DataAccess.ExecuteNonQuery("SaveInvoiceCredit",
                   "@invoiceGuid", invoiceGuid,
                   "@creditId", creditId,
                   "@creditAmount", creditAmount,
                    "@basrerent", BaseRent,
                      "@civicfacility", CivicFacility,
                       "@supplemental", Supplemental,
                        "@pilot", pilot,
                   "@userDescription", userDesc);
            }
        }

        public static void ClearInvoiceRollbacks(Guid invoiceGuid)
        {
            DataAccess.DataAccess.ExecuteNonQuery("ClearInvoiceRollbacks", "@invoiceGuid", invoiceGuid);
        }
        
        public static void SaveInvoiceRollbacks(Guid invoiceGuid, Guid buildingGuid, int invoiceComponentId, DateTime dateFrom, 
            DateTime dateTo, decimal amount, DateTime invoiceDate, Guid userGuid)
        {
            try
            {
                DataAccess.DataAccess.ExecuteNonQuery(
                    "SaveInvoiceRollback",
                    "@invoiceGuid", invoiceGuid,
                    "@buildingGuid", buildingGuid,
                    "@invoiceComponentId", invoiceComponentId,
                    "@datefrom", dateFrom,
                    "@dateTo", dateTo,
                    "@amount", amount,
                    "@invoiceDate", invoiceDate,
                    "@userGuid", userGuid);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                if (invoiceGuid != null)
                {
                    sb.AppendLine("InvoiceGuid: ");
                    sb.Append(invoiceGuid.ToString());
                }
                if (buildingGuid != null)
                {
                    sb.AppendLine("BuildingGuid: ");
                    sb.Append(buildingGuid.ToString());
                }
                sb.AppendLine("InvoiceComponentId: ");
                sb.Append(invoiceComponentId.ToString());
                sb.AppendLine("DateFrom: ");
                sb.Append(dateFrom.ToShortDateString());
                sb.AppendLine("DateTo: ");
                sb.Append(dateTo.ToShortDateString());
                sb.AppendLine("Amount: ");
                sb.Append(amount.ToString());
                sb.AppendLine("InvoiceDate: ");
                sb.Append(invoiceDate.ToShortDateString());
                sb.AppendLine("UserGuid: ");
                sb.Append(userGuid.ToString());

                LogWriter.LogError(sb.ToString());
            }
        }

        public static decimal CalculateAdjustmentDifference(string adjustType, DateTime dateFrom, DateTime dateTo,
            DateTime currentDate, Guid buildingGuid, decimal amount)
        {
            try
            {
                object adjDiff = DataAccess.DataAccess.ExecuteScalar(CommandType.Text, "Select dbo.CalcAdjustmentDifference(@adjustType, @dateFrom, @dateTo, @currentDate, @buildingGuid, @amount)",
                    "@adjustType", adjustType, "@dateFrom", dateFrom, "@dateTo", dateTo, "@currentDate", currentDate, "@buildingGuid", buildingGuid, "@amount", amount);
                if (adjDiff == null) { adjDiff = 0m; }
                return (decimal)adjDiff;
            }
            catch(Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                if (adjustType != null)
                {
                    sb.AppendLine("AdjustType: ");
                    sb.Append(adjustType.ToString());
                }
                if (buildingGuid != null)
                {
                    sb.AppendLine("BuildingGuid: ");
                    sb.Append(buildingGuid.ToString());
                }
                sb.AppendLine("DateFrom: ");
                sb.Append(dateFrom.ToShortDateString());
                sb.AppendLine("DateTo: ");
                sb.Append(dateTo.ToShortDateString());
                sb.AppendLine("Amount: ");
                sb.Append(amount.ToString());
                sb.AppendLine("CurrentDate: ");
                sb.Append(currentDate.ToShortDateString());

                LogWriter.LogError(sb.ToString());
                return 0;
            }
        }
    }
}
