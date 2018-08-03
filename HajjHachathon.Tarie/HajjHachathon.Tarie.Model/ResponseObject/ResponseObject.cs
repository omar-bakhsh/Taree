using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HajjHachathon.Tarie.Model.Contracts;

namespace HajjHachathon.Tarie.Model.ResponseObject
{
    public class ResponseObject
    {
        public Status Status { get; set; }

        public string Message { get; set; }

        public string InternalMessage { get; set; }
    }

    public enum Status
    {
        Success,
        Fail,
        Validation
    }
    public class NewObjectResponseObject : ResponseObject
    {
        public int Id { get; set; }
    }
    public class BoolResponseObject : ResponseObject
    {
        public bool Flag { get; set; }
    }
    public class CaseResponseObject : ResponseObject
    {
        public CaseContract Case { get; set; }
    }
    public class CasesResponseObject : ResponseObject
    {
        public List<CaseContract> Cases { get; set; }
    }
    public class AgentResponseObject : ResponseObject
    {
        public AgentContract Agent { get; set; }
    }
    public class AgentsResponseObject : ResponseObject
    {
        public List<AgentContract> Agents { get; set; }
    }
}
