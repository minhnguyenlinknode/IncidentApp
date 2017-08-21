using BusinessManager;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncidentWebApp.Classes
{
    public class Utils
    {
        public static List<SelectListItem> GetAllIncidentTypeList()
        {
            var allIncidentType = IncidentTypeManager.GetAllIncidentTypes();

            return allIncidentType.Select(n => new SelectListItem {
                                                    Value = n.Id.ToString(),
                                                    Text = n.IncidentTypeName })
                                  .ToList();            
        }
    }
}