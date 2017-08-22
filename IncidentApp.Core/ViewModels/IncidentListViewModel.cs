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
    public class IncidentListViewModel : MvxViewModel
    {
        private IAppProvider _appProvider;
        private IIncidentServices _incidentServices;

        public IEnumerable<Incident> Incidents { get; set; }

        public IncidentListViewModel(IAppProvider appProvider, IIncidentServices incidentServices)
        {
            _appProvider = appProvider;
            _incidentServices = incidentServices;
        }

        #region Load Data Command 

        MvxAsyncCommand _loadDataCommand;
        public MvxAsyncCommand LoadDataCommand
        {
            get
            {
                return _loadDataCommand ?? (_loadDataCommand = new MvxAsyncCommand(LoadDataCommandAsync));
            }
        }

        async Task LoadDataCommandAsync()
        {
            this.Incidents = await _incidentServices.GetAllIncidentsAsync();
            _appProvider.AllIncidentTypes = await _incidentServices.GetAllIncidentTypesAsync();
        }

        #endregion

        #region Item Selected Command 

        MvxCommand<Incident> _itemSelectedCommand;

        public MvxCommand<Incident> ItemSelectedCommand
        {
            get
            {
                return _itemSelectedCommand ?? (_itemSelectedCommand = new MvxCommand<Incident>(ItemSelected));
            }
        }

        void ItemSelected(Incident incident)
        {
            _appProvider.SelectedIncident = incident;
            ShowViewModel<IncidentDetailViewModel>();
        }

        #endregion

    }
}
