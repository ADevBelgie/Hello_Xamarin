using Hello_Xamarin.Models;

namespace Hello_Xamarin.ViewModels
{
    public class FruitDetailViewModel: BaseViewModel
    {
        public Fruit Fruit { get; set; }

        public FruitDetailViewModel()
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
    }
}
