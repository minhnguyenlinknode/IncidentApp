using BusinessObject;
using ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IncidentWebApp.Classes
{
    public class Utils
    {
        public async static Task<List<SelectListItem>> GetAllIncidentTypeList()
        {
            var allIncidentType = await IncidentClientApi.GetAllIncidentTypesAsync();

            return allIncidentType.Select(n => new SelectListItem {
                                                    Value = n.Id.ToString(),
                                                    Text = n.IncidentTypeName })
                                  .ToList();            
        }
    }
}