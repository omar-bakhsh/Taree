using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HajjHachathon.Tarie.Model.Contracts;
using HajjHachathon.Tarie.Model.ResponseObject;

namespace HajjHachathon.Tarie.Presentation.api
{
    public class CaseController : ApiController
    {
        // GET api/<controller>
        public CasesResponseObject Get()
        {
            return BLL.Bll.GetUnresolvedCases();
        }

        // GET api/<controller>/5
        public CaseResponseObject Get(int id)
        {
            return BLL.Bll.GetCaseById(id);
        }

        // POST api/<controller>
        public NewObjectResponseObject Post([FromBody]CaseContract _case)
        {
            return BLL.Bll.CreateCase(_case);
        }

        // PUT api/<controller>/5
        public BoolResponseObject Put(int id, [FromBody]CaseContract _case)
        {
            return BLL.Bll.ResolveCase(_case);
        }

        // DELETE api/<controller>/5
        public BoolResponseObject Delete(int id)
        {
            return BLL.Bll.DeleteCase(id);
        }
    }
}