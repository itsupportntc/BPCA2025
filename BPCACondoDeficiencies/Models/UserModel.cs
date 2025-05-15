using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class UserModel
    {
        public static JsonResult GetUserManagement()
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetUserManagement")));
        }

        public static void SaveUser(Guid userGuid, Guid agencyGuid, string userName, string password, string firstName, string lastName, string emailAddress, bool isActive)
        {
            DataAccess.DataAccess.ExecuteDataTable(
                    "SaveUser",
                    "@userGuid", userGuid,
                    "@agencyGuid", agencyGuid,
                    "@userName", userName,
                    "@password", password,
                    "@firstName", firstName,
                    "@lastName", lastName,
                    "@emailAddress", emailAddress,
                    "@isActive", isActive
            );
        }

        public static void DeleteUser(Guid userGuid)
        {
            DataAccess.DataAccess.ExecuteDataTable("DeleteUser", "@userGuid", userGuid);
        }

        public static void UpdatePassword(string userName, string oldPassword, string password)
        {
            DataAccess.DataAccess.ExecuteDataTable("UpdateUserPassword", "@uid", userName, "@opwd", oldPassword, "@pwd", password);
        }
    }
}
