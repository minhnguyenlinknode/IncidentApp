using BusinessManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndAPI.Controllers
{
    //[Authorize]
    public class IncidentController : ApiController
    {
        public IEnumerable<BusinessObject.Incident> GetAllIncidents()
        {
            return IncidentManager.GetAllIncidents();
        }

        // GET api/values/5
        public IHttpActionResult GetIncident(int id)
        {
            return null;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
