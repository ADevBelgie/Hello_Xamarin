using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_Xamarin.Models
{
    public class Fruit
    {
        public Fruit()
        {

        }
        public Fruit(string species, string image)
        {
            Species = species;
            Image = image;
        }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public decimal PriceKilo { get; set; }
        public int Id { get; set; }
        public string Species { get; set; }
        public string Image { get; set; }
    }
}
