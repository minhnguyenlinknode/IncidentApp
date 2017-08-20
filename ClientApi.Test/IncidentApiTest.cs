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
            var incidents = await IncidentApi.GetAllIncidentsAsync();
            Assert.IsTrue(incidents.Count > 0);
        }
    }
}
