using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

using System.IO;
using System.Collections.ObjectModel;
using System.Drawing;
using Path = System.IO.Path;
using Color = Microsoft.Maui.Graphics.Color;
using System.Net;
using System.Net.Http.Headers;

namespace ListPMCaller.Views.Requests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateRequestPage : ContentPage
    {
        public CreateRequestPage()
        {
            InitializeComponent();
        }
    }
}