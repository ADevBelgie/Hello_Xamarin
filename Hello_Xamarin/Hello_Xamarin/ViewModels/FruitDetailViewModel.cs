using Hello_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    class FruitDetailViewModel : BaseViewModel
    {
        public Fruit FruitData { get; set; } = new Fruit("Apple", "apple.jpg");
        public FruitDetailViewModel()
        {
            FruitData.Name = "Red Apple One";
            FruitData.Weight = 200;
            FruitData.Color = "Red";
            FruitData.PriceKilo = 2.7M;
            FruitData.Id = 123456789;
        }
    }
}
