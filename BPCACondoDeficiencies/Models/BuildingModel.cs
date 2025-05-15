using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class BuildingModel
    {
        public BuildingModel() { }
        public BuildingModel(Guid buildingGuid, string name, string address1, string address2,
            string city, string state, string zipCode, int pilotPeriod, Guid agencyGuid,
            decimal commonCharges, string siteId, bool retail, DateTime managedSince, string agencyName)
        {
            BuildingGUID = buildingGuid;
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            ZipCode = zipCode;
            PilotPeriod = pilotPeriod;
            AgencyGUID = agencyGuid;
            CommonCharges = commonCharges;
            SiteID = siteId;
            Retail = retail;
            ManagedSince = managedSince;
            AgencyName = agencyName;
        }

        public Guid BuildingGUID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int PilotPeriod { get; set; }
        public Guid AgencyGUID { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CommonCharges { get; set; }
        public string SiteID { get; set; }
        public bool Retail { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime ManagedSince { get; set; }
        public string AgencyName { get; set; }

        public static JsonResult GetBuildingList(Guid agencyGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetBuildingList", "@agencyGuid", agencyGuid)));
        }

        public static JsonResult GetBuildingListforSummaryVersion(Guid agencyGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetBuildingListforSummaryVersion", "@agencyGuid", agencyGuid)));
        }
        public static JsonResult GetBuildingHeaderData(Guid buildingGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetBuildingHeaderData", "@buildingGuid", buildingGuid)));
        }
        public static JsonResult GetOwnerGuid(Guid UnitGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetOwnerGuid", "@UnitGuid", UnitGuid)));
        }
        public static JsonResult GetAddEditUnit(Guid buildingGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetAddEditUnit", "@buildingGuid", buildingGuid)));
        }
        public static JsonResult GetUnitList(Guid buildingGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetUnitList", "@buildingGuid", buildingGuid)));
        }
        public static JsonResult GetUnitInquiry(Guid unitGuid)
        {
            return new JsonResult(Utilities.DataSetToJSON(DataAccess.DataAccess.ExecuteDataSet("UnitInquiry", "@unitGuid", unitGuid)));
        }
        public static JsonResult GetAddEditSuspendedDefaultList(Guid unitGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("AddEditSuspendedDefault", "@unitGuid", unitGuid)));
        }
        public static DataSet GetBuildingSummaryReportXl(
    object buildingGuid,
    object asOf,
    object showSuspended)
        {
            return BPCACondoDeficiencies.DataAccess.DataAccess.ExecuteDataSet("BuildingSummaryReport", (object)"@buildingGuid", buildingGuid, (object)"@asofdate", asOf, (object)"@showSuspended", showSuspended);
        }

        public static void UpdateBuilding(Guid buildingGuid, string buildingName, string address1, string address2, string city, string state, string zipCode,
            int pilotPeriod, Guid agencyGuid, decimal commonCharges, string siteId, bool retail, DateTime managedSince)
        {
            DataAccess.DataAccess.ExecuteDataTable("UpdateAgency",
               "@buildingGuid", buildingGuid,
               "@name", buildingName,
               "@add1", address1,
               "@add2", address2,
               "@city", city,
               "@state", state,
               "@zipCode", zipCode,
               "@pilot", pilotPeriod,
               "@agencyGuid", agencyGuid,
               "@commonCharges", commonCharges,
               "@siteId", siteId,
               "@retail", retail,
               "@managedSince", managedSince);
        }

        public static void InsertBuilding(string buildingName, string address1, string address2, string city, string state, string zipCode,
            int pilotPeriod, Guid agencyGuid, decimal commonCharges, string siteId, bool retail, DateTime managedSince)
        {
            DataAccess.DataAccess.ExecuteDataTable("InsertAgency",
              "@name", buildingName,
              "@add1", address1,
              "@add2", address2,
              "@city", city,
              "@state", state,
              "@zipCode", zipCode,
              "@pilot", pilotPeriod,
              "@agencyGuid", agencyGuid,
              "@commonCharges", commonCharges,
              "@siteId", siteId,
              "@retail", retail,
              "@managedSince", managedSince);
        }

        public static void DeletePayment(int trxId, Guid userGuid, DateTime worksheetDate, decimal paidAmt)
        {
            DataAccess.DataAccess.ExecuteNonQuery("SavePaymentDelete", "@trxid", trxId, "@userGuid", userGuid,
                "@worksheetDate", worksheetDate, "@paidAmt", paidAmt);
        }
        public static void ReinstatePayment(int trxId, Guid userGuid)
        {
            DataAccess.DataAccess.ExecuteNonQuery("SavePaymentDelete", "@trxid", trxId, "@userGuid", userGuid);
        }

    }
}
