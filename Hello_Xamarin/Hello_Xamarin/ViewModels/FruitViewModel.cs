using Hello_Xamarin.Models;
using Hello_Xamarin.Services;
using Hello_Xamarin.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    public class FruitViewModel : BaseViewModel
    {
        
        public ObservableCollection<Fruit> Fruit { get; set; } = new ObservableCollection<Fruit>();

        private Fruit _selectedFruit;

        private FruitService fruitService;

        public string Klant { get; set; } = "Verkoper";

        public Command UpdateFruitCommand { get; }

        public Command AddFruitCommand { get; }

        public Command RemoveFruitCommand { get; }

        public Command<Fruit> ItemTappedCommand { get; }

        public FruitViewModel()
        {
            fruitService = new FruitService();
            var list = fruitService.GetFruits();

            foreach (var item in list)
            {
                Fruit.Add(item);
            }

            UpdateFruitCommand = new Command(OnFruitUpdate);
            AddFruitCommand = new Command(OnAddFruit);
            RemoveFruitCommand = new Command(OnRemoveFruit);

            // Pass an item into an event by placing it in generic tags
            ItemTappedCommand = new Command<Fruit>(OnItemTappedAsync);
        }

        private async void OnItemTappedAsync(Fruit fruit)
        {
            await Shell.Current.GoToAsync($"{nameof(FruitDetailPage)}?{nameof(FruitDetailViewModel.FruitID)}={fruit.Id}");
        }

        public Fruit SelectedFruit
        {
            get => _selectedFruit;
            set
            {
                SetProperty(ref _selectedFruit, value);
                OnItemTappedAsync(value);
            }
        }

        private void OnFruitUpdate(object obj)
        {
        }

        private void OnAddFruit()
        {
            Fruit.Add(new Fruit(4, "Apple", "apple.jpg"));
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