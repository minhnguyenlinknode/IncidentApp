using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class tblIncident
    {
        public tblIncident()
        {
        }

        public static BusinessObject.Incident CreateObject(Incident entity)
        {
            return new BusinessObject.Incident()
            {
                Id = entity.Id,
                IncidentName = entity.IncidentName,
                CreatedDate = entity.CreatedDate,
                NumberPeople = entity.NumberPeople,
                IsUrgent = entity.IsUrgent,
                IncidentType = entity.IncidentType
            };
        }

        public static List<BusinessObject.Incident> GetAllIncidents()
        {
            using (var db = IncidentDatabaseEntities.Create())
            {
                return db.Incidents.ToList()
                                   .Select(n => CreateObject(n))
                                   .ToList();
            }
        }
    }
}
