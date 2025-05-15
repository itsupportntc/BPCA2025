using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class WorksheetModel
    {

        public Guid InvoiceGuid { get; set; }
        public Guid BuildingGuid { get; set; }
        public int WorksheetId { get; set; }

        public WorksheetModel(Guid invoiceGuid, Guid userGuid)
        {
            InvoiceGuid = invoiceGuid;
            WorksheetId = (int)DataAccess.DataAccess.ExecuteScalar(CommandType.Text,
                "select dbo.GetWorksheetId(@invoiceGuid)", "@invoiceGuid", invoiceGuid);
            if(WorksheetId == -1)
            {
                WorksheetId = int.Parse(DataAccess.DataAccess.ExecuteDataTable(
                    "CreateWorksheet", 
                    "@invoiceGuid", InvoiceGuid,
                    "@userGuid", userGuid).Rows[0][0].ToString());
            }
            BuildingGuid = new Guid(DataAccess.DataAccess.ExecuteScalar(CommandType.Text,
                "select dbo.GetInvoiceBuildingGUID(@invoiceGuid)", "@invoiceGuid", invoiceGuid).ToString());
        }
        public WorksheetModel(Guid invoiceGuid, int worksheetId, Guid buildingGuid)
        {
            InvoiceGuid = invoiceGuid;
            WorksheetId = worksheetId;
            BuildingGuid = buildingGuid;
        }

        #region Static Methods
        public static JsonResult GetWorksheetHistory(Guid buildingGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetWorksheetHistory", "@buildingGuid", buildingGuid)));
        }
        public static JsonResult GetOpenWorksheets(Guid userGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetOpenWorksheets", "@userGuid", userGuid)));
        }
        public static JsonResult GetWorksheetInvoice(Guid invoiceGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetInvoice", "@invoiceguid", invoiceGuid)));
        }
        public static JsonResult GetWorksheetDetails(int worksheetId)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetWorksheetDetails", "@worksheetId", worksheetId)));
        }
        public static void InsertDefault(Guid unitGuid, Guid ownerGuid, int worksheetId)
        {
            DataAccess.DataAccess.ExecuteNonQuery("InsertDefault", 
                "@unitGuid", unitGuid,
                "@ownerGuid", ownerGuid,
                "@worksheetId", worksheetId);
        }
        public static void InsertPayments(Guid unitGuid, Guid ownerGuid, int worksheetId, int numPayments)
        {
            DataAccess.DataAccess.ExecuteNonQuery("InsertPayments",
                "@unitGuid", unitGuid,
                "@ownerGuid", ownerGuid,
                "@worksheetId", worksheetId,
                "@numPayments", numPayments);
        }
        public static void DeleteWorksheetTransaction(int trxId)
        {
            DataAccess.DataAccess.ExecuteNonQuery("DeleteWorksheetTransaction",
                "@trxid", trxId);
        }
        public static void RejectWorksheet(int worksheetId)
        {
            DataAccess.DataAccess.ExecuteNonQuery("RejectWorksheet",
                "@worksheetId", worksheetId);
        }
        public static void SubmitWorksheet(int worksheetId, Guid userGuid)
        {
            DataAccess.DataAccess.ExecuteNonQuery("SubmitWorksheet", "@worksheetId", worksheetId, "@userGuid", userGuid);
        }
        public static void ApproveWorksheet(int worksheetId, Guid userGuid)
        {
            DataAccess.DataAccess.ExecuteNonQuery("ApproveWorksheet", "@worksheetId", worksheetId, "@userGuid", userGuid);
        }
        public static JsonResult GetSubmittedWorksheets()
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetSubmittedWorksheets")));
        }
        #endregion
    }
}
