using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BPCACondoDeficiencies.Models;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class AgencyModel
    {

        public static JsonResult GetAgencies()
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(
                DataAccess.DataAccess.ExecuteDataTable("GetAgencies")));
        }

        public static void UpdateAgency(Guid agencyGuid, string agencyCode, string agencyName, string address1,
            string address2, string city, string state, string zip, string contact, string phone, string fax)
        {
                DataAccess.DataAccess.ExecuteDataTable("UpdateAgency",
                "@agencyGuid", agencyGuid,
                "@agencyCode", agencyCode,
                "@agencyName", agencyName,
                "@add1", address1,
                "@add2", address2,
                "@city", city,
                "@state", state,
                "@zip", zip,
                "@contact", contact,
                "@phone", phone,
                "@fax", fax
                );
        }

        public static void InsertAgency(string agencyCode, string agencyName, string address1,
           string address2, string city, string state, string zip, string contact, string phone, string fax)
        {
            DataAccess.DataAccess.ExecuteDataTable("InsertAgency",
                "@agencyCode", agencyCode,
                "@agencyName", agencyName,
                "@add1", address1,
                "@add2", address2,
                "@city", city,
                "@state", state,
                "@zip", zip,
                "@contact", contact,
                "@phone", phone,
                "@fax", fax
            );
        }

        public static void DeleteAgency(Guid agencyGuid)
        {
            DataAccess.DataAccess.ExecuteDataTable("DeleteAgency", "@agencyGuid", agencyGuid);
        }
    }

   

}
