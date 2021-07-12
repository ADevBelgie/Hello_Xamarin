using Hello_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Hello_Xamarin.ViewModels
{
    public class DetailsViewModel : BaseViewModel
    {
        public DetailsViewModel()
        {
            Fruit = new Fruit
            {
                Color = "Red",
                Image = "apple.jpg",
                Name = "Red Apple",
                PriceKilo = 2,
                Species = "Akane",
                Weight = 25
            };

        }
        public Fruit Fruit { get; set; }
    }
}
