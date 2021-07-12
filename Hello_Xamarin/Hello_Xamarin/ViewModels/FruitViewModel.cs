using Hello_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    public class FruitViewModel
    {
        public List<Fruit> Fruit { get; set; } = new List<Fruit>();
        public string Klant { get; set; } = "Verkoper";
        
        public Command UpdateFruit { get; }
        public FruitViewModel()
        {
            Fruit.Add(new Fruit("Apple", "apple.jpg"));
            Fruit.Add(new Fruit("Banana", "Banana.jpg"));
            Fruit.Add(new Fruit("Pear", "pear.jpg"));
            UpdateFruit = new Command(OnFruitUpdate);
        }

        private void OnFruitUpdate(object obj)
        {
            
        }
    }
}
