using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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

        public static async Task<List<BusinessObject.Incident>> GetAllIncidentsAsync()
        {
            using (var db = IncidentDatabaseEntities.Create())
            {
                var incidents = await db.Incidents
                                        .ToListAsync();
                return incidents.Select(n => CreateObject(n))
                                .ToList();
            }
        }

        public static async Task<BusinessObject.Incident> GetIncidentByIdAsync(int id)
        {
            using (var db = IncidentDatabaseEntities.Create())
            {
                BusinessObject.Incident result = null;

                var incident = await db.Incidents
                                       .SingleOrDefaultAsync(n => n.Id == id);
                if (incident != null)
                    result = CreateObject(incident);

                return result;
            }
        }

        public static async Task<int> CreateIncidentAsync(BusinessObject.Incident incident)
        {
            using (var db = IncidentDatabaseEntities.Create())
            {
                var entity = new Incident()
                {
                    IncidentName = incident.IncidentName,
                    CreatedDate = incident.CreatedDate,
                    NumberPeople = incident.NumberPeople,
                    IsUrgent = incident.IsUrgent,
                    IncidentType = incident.IncidentType
                };

                db.Incidents.Add(entity);

                await db.SaveChangesAsync();

                return entity.Id;
            }
        }

        public static async Task UpdateIncidentAsync(BusinessObject.Incident incident)
        {
            using (var db = IncidentDatabaseEntities.Create())
            {
                var entity = await db.Incidents.SingleOrDefaultAsync(n => n.Id == incident.Id);

                if (entity != null)
                {
                    entity.IncidentName = incident.IncidentName;
                    entity.CreatedDate = incident.CreatedDate;
                    entity.NumberPeople = incident.NumberPeople;
                    entity.IsUrgent = incident.IsUrgent;
                    entity.IncidentType = incident.IncidentType;

                    await db.SaveChangesAsync();
                }
            }
        }

        public static async Task DeleteIncidentAsync(int id)
        {
            using (var db = IncidentDatabaseEntities.Create())
            {
                var entity = await db.Incidents.SingleOrDefaultAsync(n => n.Id == id);

                if (entity != null)
                {
                    db.Incidents.Remove(entity);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
