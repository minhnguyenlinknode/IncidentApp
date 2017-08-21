using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApi
{
    public class IncidentClientApi
    {
        static readonly string BaseApiUrl = "http://localhost/IncidentApi/api/incident";

        public static async Task<List<Incident>> GetAllIncidentsAsync()
        {
            return await HttpHelper.GetJsonAsync<List<Incident>>(String.Format("{0}/GetAllIncidentsAsync", BaseApiUrl));
        }

        public static async Task<Incident> GetIncidentByIdAsync(int id)
        {
            return await HttpHelper.GetJsonAsync<Incident>(String.Format("{0}/GetIncidentAsync/{1}", BaseApiUrl, id));
        }

        public static async Task<int> CreateIncidentAsync(Incident incident)
        {
            var createdID = await HttpHelper.PostJsonAsync<Incident>(String.Format("{0}/CreateIncidentAsync", BaseApiUrl), incident);
            return Convert.ToInt32(createdID);
        }

        public static async Task UpdateIncidentAsync(Incident incident)
        {
            await HttpHelper.PostJsonAsync<Incident>(String.Format("{0}/UpdateIncidentAsync", BaseApiUrl), incident);
        }

        public static async Task DeleteIncidentAsync(int id)
        {
            await HttpHelper.DeleteJsonAsync(String.Format("{0}/DeleteIncidentAsync/{1}", BaseApiUrl, id));
        }
    }
}
