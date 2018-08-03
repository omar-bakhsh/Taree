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
    public class LocationController : ApiController
    {
        // GET api/<controller>
        [Route("api/Location/{id}/{longi}/{lat}")]
        public BoolResponseObject Get(int id,string longi,string lat)
        {
            return BLL.Bll.SetLocation(new CaseContract { Id = id, Longitude = longi.Replace("_", "."), Latidude = lat.Replace("_", "."), Confirmation = true });
        }
    }
}