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
        public static List<BusinessObject.Incident> GetAllIncidents()
        {
            return tblIncident.GetAllIncidents();
        }
    }
}
