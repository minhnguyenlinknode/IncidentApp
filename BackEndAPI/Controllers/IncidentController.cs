using BusinessManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BackEndAPI.Controllers
{
    //[Authorize]
    public class IncidentController : ApiController
    {
        public async Task<IEnumerable<BusinessObject.Incident>> GetAllIncidentsAsync()
        {
            return await IncidentManager.GetAllIncidentsAsync();
        }

        public async Task<IHttpActionResult> GetIncidentAsync(int id)
        {
            var incident = await IncidentManager.GetIncidentByIdAsync(id);

            if (incident == null)
                return NotFound();

            return Ok(incident);
        }

        // POST CREATE
        public async Task<int> CreateIncidentAsync(BusinessObject.Incident incident)
        {
            return await IncidentManager.CreateIncidentAsync(incident);
        }

        // POST UPDATE
        public async Task UpdateIncidentAsync(BusinessObject.Incident incident)
        {
            await IncidentManager.UpdateIncidentAsync(incident);
        }

        // POST DELETE
        public async Task DeleteIncidentAsync(int id)
        {
            await IncidentManager.DeleteIncidentAsync(id);
        }
    }
}
