using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApi
{
    public class IncidentApi
    {
        static readonly string BaseApiUrl = "http://localhost/IncidentApi/api/";

        public static async Task<List<Incident>> GetAllIncidentsAsync()
        {
            return await HttpHelper.GetJsonAsync<List<Incident>>(BaseApiUrl + "incident");
        }
    }
}
