using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public class IncidentTypeManager
    {
        public static List<IncidentType> GetAllIncidentTypes()
        {
            var items = new List<IncidentType>();

            items.Add(new IncidentType { IncidentTypeName = "Incident Type 1", Id = 1 });
            items.Add(new IncidentType { IncidentTypeName = "Incident Type 2", Id = 2 });
            items.Add(new IncidentType { IncidentTypeName = "Incident Type 3", Id = 3 });

            return items;
        }
    }
}
