using Hello_Xamarin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hello_Xamarin.Services
{
    public interface IStarWarsService
    {
        Task<List<StarWarsCharacter>> GetStarWarsCharacters(int amount = 10);
    }
}