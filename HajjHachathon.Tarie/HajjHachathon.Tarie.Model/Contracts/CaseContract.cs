using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajjHachathon.Tarie.Model.Contracts
{
    public class CaseContract
    {
        public int Id { get; set; }
        public bool? Confirmation { get; set; }
        public string DeviceId { get; set; }
        public string Longitude { get; set; }
        public string Latidude { get; set; }
        public bool? IsAssigned { get; set; }
        public string Resolution { get; set; }
        public int? AgentId { get; set; }
        public bool? Resolved { get; set; }
        public string ResolutionDate { get; set; }
        public DateTime? CaseDate { get; set; }
        public DateTime? AssignmentDate { get; set; }
    }
}
