using ListPMCaller;
using ListPMCaller.Views.Requests;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ListPM_Caller;

namespace ListPMCallerBee.Views.Requests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommentsPage : ContentPage
    {
        public CommentsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
#if ANDROID
			        Platform.CurrentActivity?.Window?.SetSoftInputMode(Android.Views.SoftInput.AdjustResize);
#endif
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
#if ANDROID
        Platform.CurrentActivity?.Window?.SetSoftInputMode(Android.Views.SoftInput.AdjustPan);
#endif
        }
    }
}