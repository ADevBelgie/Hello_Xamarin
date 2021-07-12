using Hello_Xamarin.ViewModels;
using Hello_Xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Hello_Xamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(BindingPage), typeof(BindingPage));
            Routing.RegisterRoute(nameof(FruitDetailPage), typeof(FruitDetailPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
