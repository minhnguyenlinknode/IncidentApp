using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ClientApi.Test
{
    [TestClass]
    public class IncidentApiTest
    {
        [TestMethod]
        public async Task GetAllIncidentsTest()
        {
            var incidents = await IncidentClientApi.GetAllIncidentsAsync();
            Assert.IsTrue(incidents.Count > 0);
        }

        [TestMethod]
        public async Task GetIncidentByIdTest()
        {
            var incident = await IncidentClientApi.GetIncidentByIdAsync(1);
            Assert.AreEqual(incident.Id, 1);
        }

        [TestMethod]
        public async Task CreateDeleteIncidentTest()
        {
            var newIncidentInfo = new BusinessObject.Incident()
            {
                IncidentName = "New Incident Test",
                CreatedDate = DateTime.Now,
                NumberPeople = 6,
                IsUrgent = false,
                IncidentType = 1
            };

            var incidentId = await IncidentClientApi.CreateIncidentAsync(newIncidentInfo);

            //Test 1
            Assert.IsTrue(incidentId > 0);

            var incident = await IncidentClientApi.GetIncidentByIdAsync(incidentId);

            //Test 2
            Assert.AreEqual(incident.IncidentName, newIncidentInfo.IncidentName);
            Assert.AreEqual(incident.NumberPeople, newIncidentInfo.NumberPeople);
            Assert.AreEqual(incident.IsUrgent, newIncidentInfo.IsUrgent);
            Assert.AreEqual(incident.IncidentType, newIncidentInfo.IncidentType);

            //Test Delete
            await IncidentClientApi.DeleteIncidentAsync(incidentId);

            incident = await IncidentClientApi.GetIncidentByIdAsync(incidentId);

            Assert.IsNull(incident);
        }

        [TestMethod]
        public async Task UpdateIncidentTest()
        {
            var newIncidentInfo = new BusinessObject.Incident()
            {
                Id = 1,
                IncidentName = "Updated Incident Test",
                CreatedDate = DateTime.Now,
                NumberPeople = 8,
                IsUrgent = true,
                IncidentType = 2
            };

            await IncidentClientApi.UpdateIncidentAsync(newIncidentInfo);

            var incident = await IncidentClientApi.GetIncidentByIdAsync(newIncidentInfo.Id);

            //Test 1
            Assert.AreEqual(incident.IncidentName, newIncidentInfo.IncidentName);
            Assert.AreEqual(incident.NumberPeople, newIncidentInfo.NumberPeople);
            Assert.AreEqual(incident.IsUrgent, newIncidentInfo.IsUrgent);
            Assert.AreEqual(incident.IncidentType, newIncidentInfo.IncidentType);

        }
        
    }
}
