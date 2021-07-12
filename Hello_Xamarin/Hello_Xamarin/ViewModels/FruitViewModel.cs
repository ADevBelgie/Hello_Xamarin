using Hello_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    public class FruitViewModel : BaseViewModel
    {
        public ObservableCollection<Fruit> Fruit { get; set; } = new ObservableCollection<Fruit>();
        public string Klant { get; set; } = "Verkoper";
        
        public Command UpdateFruitCommand { get; }

        public Command AddFruitCommand { get; }

        public Command RemoveFruitCommand { get; }

        public FruitViewModel()
        {
            Fruit.Add(new Fruit("Apple", "apple.jpg"));
            Fruit.Add(new Fruit("Banana", "Banana.jpg"));
            Fruit.Add(new Fruit("Pear", "pear.jpg"));

            UpdateFruitCommand = new Command(OnFruitUpdate);
            AddFruitCommand = new Command(OnAddFruit);
            RemoveFruitCommand = new Command(OnRemoveFruit);
        }

        private void OnFruitUpdate(object obj)
        {
            
        }

        private void OnAddFruit()
        {
            Fruit.Add(new Fruit("Apple", "apple.jpg"));
        }

        private void OnRemoveFruit()
        {
            if (Fruit.Count >0)
            {
                Fruit.RemoveAt(Fruit.Count - 1);
            }
        }
    }
}
