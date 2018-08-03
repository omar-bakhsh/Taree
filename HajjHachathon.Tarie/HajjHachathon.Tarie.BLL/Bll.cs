using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HajjHachathon.Tarie.Model;
using HajjHachathon.Tarie.Model.Contracts;
using HajjHachathon.Tarie.Model.ResponseObject;

namespace HajjHachathon.Tarie.BLL
{
    public class Bll
    {
        public static NewObjectResponseObject CreateCase(CaseContract _case)
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var emergencyCase = new Case
                {
                    AgentId = _case.AgentId,
                    Confirmation = _case.Confirmation,
                    DeviceId = _case.DeviceId,
                    IsAssigned = _case.IsAssigned,
                    Latidude = _case.Latidude,
                    Longitude = _case.Longitude,
                    Resolution = _case.Resolution,
                    AssignmentDate = _case.AssignmentDate,
                    CaseDate = DateTime.Now,
                    ResolutionDate = _case.ResolutionDate,
                    Resolved = _case.Resolved
                };
                unitOfWork.Cases.Add(emergencyCase);
                unitOfWork.Save();
                return new NewObjectResponseObject { Status = Status.Success, Id = emergencyCase.Id, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new NewObjectResponseObject { Status = Status.Fail, Message = "", InternalMessage = ex.Message };
            }
        }
        private static BoolResponseObject UpdateCase(CaseContract _case)
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var emergencyCase = unitOfWork.Cases.GetAll().FirstOrDefault(a => a.Id == _case.Id);
                if (emergencyCase != null)
                {
                    emergencyCase.AgentId = _case.AgentId;
                    emergencyCase.Confirmation = _case.Confirmation;
                    emergencyCase.DeviceId = _case.DeviceId;
                    emergencyCase.IsAssigned = _case.IsAssigned;
                    emergencyCase.Latidude = _case.Latidude;
                    emergencyCase.Longitude = _case.Longitude;
                    emergencyCase.Resolution = _case.Resolution;
                    emergencyCase.AssignmentDate = _case.AssignmentDate;
                    //emergencyCase.CaseDate = _case.CaseDate;
                    emergencyCase.ResolutionDate = _case.ResolutionDate;
                    emergencyCase.Resolved = _case.Resolved;
                    unitOfWork.Save();
                }
                else
                {
                    throw new Exception("Invalid Case Id");
                }
                return new BoolResponseObject { Status = Status.Success, Flag = true, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new BoolResponseObject { Status = Status.Fail, Message = "Operation Faild", InternalMessage = ex.Message };
            }
        }
        public static BoolResponseObject DeleteCase(int id)
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var emergencyCase = unitOfWork.Cases.GetAll().FirstOrDefault(a => a.Id == id);
                if (emergencyCase != null)
                {
                    unitOfWork.Cases.Delete(emergencyCase);
                    unitOfWork.Save();
                }
                else
                {
                    throw new Exception("Invalid Case Id");
                }
                return new BoolResponseObject { Status = Status.Success, Flag = true, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new BoolResponseObject { Status = Status.Fail, Flag = false, Message = "Operation Faild", InternalMessage = ex.Message };
            }
        }
        public static CaseResponseObject GetCaseById(int id)
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var emergencyCase = unitOfWork.Cases.GetAll().FirstOrDefault(a => a.Id == id);
                CaseContract emergencyCaseResponse = null;
                if (emergencyCase != null)
                {
                    emergencyCaseResponse=new CaseContract
                    {
                        Id = emergencyCase.Id,
                        AgentId = emergencyCase.AgentId,
                        Resolution = emergencyCase.Resolution,
                        Longitude = emergencyCase.Longitude,
                        Latidude = emergencyCase.Latidude,
                        Confirmation = emergencyCase.Confirmation,
                        DeviceId = emergencyCase.DeviceId,
                        IsAssigned = emergencyCase.IsAssigned,
                        AssignmentDate = emergencyCase.AssignmentDate,
                        CaseDate = emergencyCase.CaseDate,
                        ResolutionDate = emergencyCase.ResolutionDate,
                        Resolved = emergencyCase.Resolved,
                    };
                }
                else
                {
                    throw new Exception("Invalid Case Id");
                }
                return new CaseResponseObject { Status = Status.Success, Case = emergencyCaseResponse, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new CaseResponseObject { Status = Status.Fail, Message = "Operation Faild", InternalMessage = ex.Message };
            }
        }
        public static CasesResponseObject GetUnresolvedCases()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var emergencyCases = unitOfWork.Cases.GetAll().Where(a => a.Confirmation==true &&( a.Resolved == null || a.Resolved == false)).OrderByDescending(a => a.CaseDate);

                var emergencyCasesResponse = emergencyCases.Select(a=>new CaseContract
                {
                    Id = a.Id,
                    AgentId = a.AgentId,
                    Resolution = a.Resolution,
                    Longitude = a.Longitude,
                    Latidude = a.Latidude,
                    Confirmation = a.Confirmation,
                    DeviceId = a.DeviceId,
                    IsAssigned = a.IsAssigned,
                    ResolutionDate = a.ResolutionDate,
                    CaseDate = a.CaseDate,
                    AssignmentDate = a.AssignmentDate,
                    Resolved = a.Resolved
                }).ToList();
                return new CasesResponseObject { Status = Status.Success, Cases = emergencyCasesResponse, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new CasesResponseObject { Status = Status.Fail, Message = "Operation Faild", InternalMessage = ex.Message };
            }
        }
        private static BoolResponseObject UpdateAgent(AgentContract _agent)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var agent = unitOfWork.Agents.GetAll().FirstOrDefault(a => a.Id == _agent.Id);
                agent.Id = _agent.Id;
                agent.FirstName = _agent.FirstName;
                agent.IsOccupied = _agent.IsOccupied;
                agent.LastName = _agent.LastName;
                agent.MobileNo = _agent.MobileNo;

                return new BoolResponseObject {Status = Status.Success, Flag = true, Message = "Successful Operation"};
            }

            catch (Exception ex)
            {
                return new BoolResponseObject
                {
                    Status = Status.Fail,
                    Message = "Operation Faild",
                    InternalMessage = ex.Message
                };
            }
        }
        private static AgentResponseObject GetAgentById(int id)
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var agent = unitOfWork.Agents.GetAll().FirstOrDefault(a => a.Id == id);
                AgentContract agentResponse = null;
                if (agent != null)
                {
                    agentResponse = new AgentContract
                    {
                        Id = agent.Id,
                        FirstName = agent.FirstName,
                        IsOccupied = agent.IsOccupied,
                        LastName = agent.LastName,
                        MobileNo = agent.MobileNo
                    };
                }
                else
                {
                    throw new Exception("Invalid Case Id");
                }
                return new AgentResponseObject { Status = Status.Success, Agent = agentResponse, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new AgentResponseObject { Status = Status.Fail, Message = "Operation Faild", InternalMessage = ex.Message };
            }
        }
        public static BoolResponseObject AssignAgent(CaseContract _case)
        {
            var updateCaseResult = UpdateCase(_case);

            var agentResult = GetFreeAgents().Agents.FirstOrDefault();//GetAgentById((int)_case.AgentId).Agent;
            agentResult.IsOccupied = true;
            var updateAgentResult = UpdateAgent(agentResult);
            var result = updateCaseResult.Flag && updateAgentResult.Flag;
            return new BoolResponseObject
            {
                Flag = result,
                Message = result==true?String.Format("Agent Name:{0} {1} - Mobile Number:{2}",agentResult.FirstName,agentResult.LastName,agentResult.MobileNo): "Faild Operation",Status = result==true?Status.Success : Status.Fail
            };
        }
        public static BoolResponseObject SetLocation(CaseContract _case)
        {
            var updateCaseResult = UpdateCase(_case);
            
            return new BoolResponseObject
            {
                Flag = updateCaseResult.Flag,
                Message = updateCaseResult.Message ,
                Status = updateCaseResult.Status
            };
        }
        public static BoolResponseObject ResolveCase(CaseContract _case)
        {
            var updateCaseResult = UpdateCase(_case);
            var agentResult = GetAgentById((int)_case.AgentId).Agent;
            agentResult.IsOccupied = false;
            var updateAgentResult = UpdateAgent(agentResult);
            var result = updateCaseResult.Flag && updateAgentResult.Flag;
            return new BoolResponseObject
            {
                Flag = result,
                Message = result == true ? "Successful Operation" : "Faild Operation",
                Status = result == true ? Status.Success : Status.Fail
            };
        }
        private static AgentsResponseObject GetFreeAgents()
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var agents = unitOfWork.Agents.GetAll().Where(a => a.IsOccupied == null||a.IsOccupied == false);
                var agentsResult=agents.Select(a=>new AgentContract
                    {
                        Id = a.Id,
                        FirstName = a.FirstName,
                        IsOccupied = a.IsOccupied,
                        LastName = a.LastName,
                        MobileNo = a.MobileNo
                    }).ToList();
                return new AgentsResponseObject { Status = Status.Success, Agents = agentsResult, Message = "Successful Operation" };
            }
            catch (Exception ex)
            {
                return new AgentsResponseObject { Status = Status.Fail, Message = "Operation Faild", InternalMessage = ex.Message };
            }
        }

    }
}
