using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class UnitOwnerModel
    {
        public string TitleName { get; set; }
        public Guid OwnerGuid { get; set; } = Guid.Empty;
        public Guid BuildingGuid { get; set; } = Guid.Empty;
        public Guid UnitGuid { get; set; } = Guid.Empty;
        public Guid AgencyGuid { get; set; } = Guid.Empty;


        public bool Empty
        {
            get
            {
                return (OwnerGuid == Guid.Empty || OwnerGuid == null);
            }
        }
        public UnitOwnerModel(Guid ownerGuid)
        {
            OwnerGuid = ownerGuid;
            GetOwner(ownerGuid);
        }

        private void GetOwner(Guid ownerGuid)
        {
            DataTable dt = DataAccess.DataAccess.ExecuteDataTable("GetOwner", "@ownerGuid", ownerGuid);
            if(dt.Rows.Count > 0)
            {
                TitleName = dt.Rows[0]["TitleName"].ToString();
                BuildingGuid = new Guid(dt.Rows[0]["buildingGuid"].ToString());
                UnitGuid = new Guid(dt.Rows[0]["unitGuid"].ToString());
                AgencyGuid = new Guid(dt.Rows[0]["agencyGuid"].ToString());
            }
        }
        public static JsonResult GetSubOwners(Guid ownerGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetUnitSubOwners", "@ownerGuid", ownerGuid)));
        }

        public static JsonResult GetUnitOwner(Guid unitGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetUnitOwner", "@unitGuid", unitGuid)));
        }

        public static int GetNumberOfMonthsInDefault(Guid unitGuid, Guid ownerGuid)
        {
            object retVal = DataAccess.DataAccess.ExecuteScalar(CommandType.Text,
                "select [dbo].[GetMonthsInDefault](@unitguid, @ownerguid)", 
                "@unitGuid", unitGuid,
                "@ownerGuid", ownerGuid);
            return (int)retVal;
        }

        public static JsonResult SaveUnitOwner(Guid ownerGuid, Guid agencyGuid, string titleName, Guid buildingGuid, Guid unitGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable(
                    "SaveUnitOwner", 
                    "@ownerGuid", ownerGuid,
                    "@agencyGuid", agencyGuid,
                    "@titleName", titleName,
                    "@buildingGuid", buildingGuid,
                    "@unitGuid", unitGuid
                )));
        }

        public static void SaveUnitSubOwner(Guid subOwnerGuid, Guid ownerGuid, string firstName, string lastName, string address1, string address2, string city, string state,
            string zipCode, string zipPlus, string phone1, string phone2, string fax, string emailAddress)
        {
            DataAccess.DataAccess.ExecuteDataTable(
                    "SaveSubOwner",
                    "@subOwnerGuid", subOwnerGuid,
                    "@ownerGuid", ownerGuid,
                    "@firstName", firstName,
                    "@lastName", lastName,
                    "@address1", address1,
                    "@address2", address2,
                    "@city", city,
                    "@state", state,
                    "@zipCode", zipCode,
                    "@zipPlus", zipPlus,
                    "@phone1", phone1,
                    "@phone2", phone2,
                    "@fax", fax,
                    "@emailAddress", emailAddress
            );
        }

        public static JsonResult FindUnitOwner(string searchType, string searchFor, Guid agencyGuid)
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable(
                    "SearchUnitOwner",
                    "@searchType", searchType,
                    "@searchfor", searchFor,
                    "@agencyguid", agencyGuid
                )));
        }
    }
}
