﻿using Hello_Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitDetailPage : ContentPage
    {
        public FruitDetailPage()
        {
            InitializeComponent();
            BindingContext = new FruitDetailViewModel();
        }
    }
}