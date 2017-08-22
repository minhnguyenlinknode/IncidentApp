using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using IncidentApp.Core.ViewModels;

namespace IncidentApp.Droid.Views
{
    [Activity]
    public class IncidentDetailView : MvxActivity<IncidentDetailViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_IncidentDetail);
        }
    }
}