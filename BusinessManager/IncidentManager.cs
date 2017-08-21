using DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public class IncidentManager
    {
        public static async Task<List<BusinessObject.Incident>> GetAllIncidentsAsync()
        {
            return await tblIncident.GetAllIncidentsAsync();
        }

        public static async Task<BusinessObject.Incident> GetIncidentByIdAsync(int id)
        {
            return await tblIncident.GetIncidentByIdAsync(id);
        }

        public static async Task<int> CreateIncidentAsync(BusinessObject.Incident incident)
        {
            return await tblIncident.CreateIncidentAsync(incident);
        }

        public static async Task UpdateIncidentAsync(BusinessObject.Incident incident)
        {
            await tblIncident.UpdateIncidentAsync(incident);
        }

        public static async Task DeleteIncidentAsync(int id)
        {
            await tblIncident.DeleteIncidentAsync(id);
        }
    }
}
