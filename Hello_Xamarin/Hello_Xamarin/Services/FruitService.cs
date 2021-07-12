using Hello_Xamarin.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hello_Xamarin.Services
{
    public class FruitService
    {
        private List<Fruit> fruits;
        public FruitService()
        {
            fruits = InitializeFruits();
        }

        public List<Fruit> GetFruits()
        {
            return fruits;
        }

        public Fruit GetFruit(int id)
        {
            return fruits.FirstOrDefault(x => x.Id == id);
        }

        private List<Fruit> InitializeFruits()
        {
            return new List<Fruit>
            {
               new Fruit(1, "Apple", "apple.jpg"),
               new Fruit(2, "Banana", "Banana.jpg"),
               new Fruit(3, "Pear", "pear.jpg")
            };
        }
    }
}