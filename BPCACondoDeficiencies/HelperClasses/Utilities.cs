using System.Text;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
namespace BPCACondoDeficiencies
{
    public class Utilities 
    {
        internal static string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }
        internal static string DataSetToJSON(DataSet dataSet)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            return JSONString;
        }

    }

    
}
