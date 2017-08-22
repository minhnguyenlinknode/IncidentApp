using IncidentApp.Core.Services;
using IncidentApp.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentApp.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            //Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IIncidentServices>(new IncidentServices());
            Mvx.RegisterSingleton<IAppProvider>(new AppProvider());

            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<IncidentListViewModel>());
        }
    }
}
