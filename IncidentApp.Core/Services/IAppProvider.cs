using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentApp.Core.Services
{
    public interface IAppProvider
    {
        Incident SelectedIncident { get; set; }
        List<IncidentType> AllIncidentTypes { get; set; }
    }

    public class AppProvider : IAppProvider
    {
        public Incident SelectedIncident { get; set; }
        public List<IncidentType> AllIncidentTypes { get; set; }
    }
}
