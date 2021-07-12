using Hello_Xamarin.Models;
using Hello_Xamarin.Services;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    [QueryProperty(nameof(FruitID), nameof(FruitID))]
    public class FruitDetailViewModel : BaseViewModel
    {
        private int fruitID;
        private FruitService fruitService;

        private Fruit fruit;

        public Fruit Fruit
        {
            get { return fruit; }
            set
            {
                fruit = value;
                OnPropertyChanged(nameof(Fruit));
            }
        }

        public int FruitID
        {
            get { return fruitID; }
            set
            {
                fruitID = value;
                LoadFruit(value);
            }
        }

        private void LoadFruit(int id)
        {
            Fruit = fruitService.GetFruit(id);
        }

        public FruitDetailViewModel()
        {
            fruitService = new FruitService();
        }
    }
}