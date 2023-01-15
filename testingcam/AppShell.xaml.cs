using System;
using System.Collections.Generic;
using testingcam.ViewModels;
using testingcam.Views;
using Xamarin.Forms;

namespace testingcam
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
