using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HajjHachathon.Tarie.Model.Contracts;

namespace HajjHachathon.Tarie.Presentation.api
{
    public class CaseIdController : ApiController
    {
        // GET api/<controller>
        public int Get()
        {
            return BLL.Bll.CreateCase(new CaseContract()).Id;
        }

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}