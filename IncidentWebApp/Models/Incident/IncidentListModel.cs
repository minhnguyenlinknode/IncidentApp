using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncidentWebApp.Models.Incident
{
    public class IncidentListModel
    {
        public List<BusinessObject.Incident> Incidents { get; set; }

        public IncidentListModel()
        {
            Incidents = new List<BusinessObject.Incident>();
        }

    }
}