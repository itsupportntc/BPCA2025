using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPCACondoDeficiencies.Models
{
    public class AgencyListItem
    {
        public Guid AgencyGuid { get; set; }
        public string AgencyName { get; set; }

        public AgencyListItem()
        { }

        public AgencyListItem(Guid agencyGuid, string agencyName)
        {
            AgencyGuid = agencyGuid;
            AgencyName = agencyName;
        }
    }
}
