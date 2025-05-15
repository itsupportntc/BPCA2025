using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BPCACondoDeficiencies.Models
{
    public class BPCAMessageModel
    {
        public int MessageId { get; private set; }
        public DateTime MessageDate { get; set; }
        public string MessageText { get; set; }
        public string User { get; set; }
        public DateTime MessageExpiration { get; set; }

        public BPCAMessageModel(int messageId, DateTime messageDate, string messageText, string user, DateTime messageExpiration)
        {
            MessageId = messageId;
            MessageDate = messageDate;
            MessageText = messageText;
            User = user;
            MessageExpiration = messageExpiration;
        }
        public BPCAMessageModel(int messageId, DateTime messageDate, string messageText, DateTime messageExpiration)
        {
            MessageId = messageId;
            MessageDate = messageDate;
            MessageText = messageText;
            MessageExpiration = messageExpiration;
        }

        public static JsonResult GetMessages()
        {
            return new JsonResult(Utilities.DataTableToJSONWithJSONNet(DataAccess.DataAccess.ExecuteDataTable("GetBPCAMessages")));
        }
    }
}
