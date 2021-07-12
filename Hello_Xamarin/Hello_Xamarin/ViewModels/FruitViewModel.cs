using Hello_Xamarin.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
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

        public Command<Fruit> ItemTappedCommand { get; }

        public FruitViewModel()
        {
            Fruit.Add(new Fruit("Apple", "apple.jpg"));
            Fruit.Add(new Fruit("Banana", "Banana.jpg"));
            Fruit.Add(new Fruit("Pear", "pear.jpg"));

            UpdateFruitCommand = new Command(OnFruitUpdate);
            AddFruitCommand = new Command(OnAddFruit);
            RemoveFruitCommand = new Command(OnRemoveFruit);

            // Pass an item into an event by placing it in generic tags
            ItemTappedCommand = new Command<Fruit>(OnItemTapped);
        }

        private void OnItemTapped(Fruit fruit)
        {
            throw new NotImplementedException();
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
            if (Fruit.Any())
            {
                Fruit.RemoveAt(Fruit.Count - 1);
            }
        }
    }
}