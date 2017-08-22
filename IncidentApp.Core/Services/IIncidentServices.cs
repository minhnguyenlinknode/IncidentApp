using BusinessObject;
using ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentApp.Core.Services
{
    public interface IIncidentServices
    {
        Task<List<Incident>> GetAllIncidentsAsync();
        Task<List<IncidentType>> GetAllIncidentTypesAsync();
    }

    class IncidentServices : IIncidentServices 
    {
        public async Task<List<Incident>> GetAllIncidentsAsync()
        {
            return await IncidentClientApi.GetAllIncidentsAsync();
        }

        public async Task<List<IncidentType>> GetAllIncidentTypesAsync()
        {
            return await IncidentClientApi.GetAllIncidentTypesAsync();
        }
    }
}
