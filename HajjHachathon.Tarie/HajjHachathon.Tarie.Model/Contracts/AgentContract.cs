using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajjHachathon.Tarie.Model.Contracts
{
    public class AgentContract
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsOccupied { get; set; }
        public string MobileNo { get; set; }
    }
}
