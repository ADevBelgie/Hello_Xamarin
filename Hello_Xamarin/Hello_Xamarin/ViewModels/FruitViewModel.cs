using Hello_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    public class FruitViewModel
    {
        public Fruit Fruit { get; set; }
        public string Klant { get; set; } = "Verkoper";
        
        public Command UpdateFruit { get; }
        public FruitViewModel()
        {
            Fruit = new Fruit();
            UpdateFruit = new Command(OnFruitUpdate);
        }

        private void OnFruitUpdate(object obj)
        {
            
        }
    }
}
