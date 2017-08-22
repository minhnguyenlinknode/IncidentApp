using BusinessObject;
using IncidentApp.Core.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentApp.Core.ViewModels
{
    public class IncidentDetailViewModel : MvxViewModel
    {
        private IAppProvider _appProvider;
        private IIncidentServices _incidentServices;
        public Incident Incident { get; set; }

        public IncidentDetailViewModel(IAppProvider appProvider, IIncidentServices incidentServices)
        {
            _appProvider = appProvider;
            _incidentServices = incidentServices;

            this.Incident = _appProvider.SelectedIncident;
        }

        public string IncidentName
        {
            get { return this.Incident.IncidentName; }
        }

        public string CreatedDate
        {
            get { return this.Incident.CreatedDate.ToString(); }
        }

        public string NumOfPeople
        {
            get { return this.Incident.NumberPeople.ToString(); }
        }

        public bool IsUrgent
        {
            get { return this.Incident.IsUrgent; }
        }

        public string IncidentType
        {
            get
            {
                var incidentType = _appProvider.AllIncidentTypes.SingleOrDefault(n => n.Id == this.Incident.IncidentType);
                return incidentType.IncidentTypeName;
            }
        }
    }
}
