using Hello_Xamarin.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hello_Xamarin.Services
{
    public class StarWarsService : IStarWarsService
    {
        private const string apiUrl = "https://starwars.egghead.training/people";

        public async Task<List<StarWarsCharacter>> GetStarWarsCharacters(int amount = 10)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync(apiUrl);
            List<StarWarsCharacter> characters = new List<StarWarsCharacter>();

            if (message.IsSuccessStatusCode)
            {
                characters = await ConvertJsonToCObjects(message);
            }

            return characters.Take(amount).ToList();
        }

        private async Task<List<StarWarsCharacter>> ConvertJsonToCObjects(HttpResponseMessage message)
        {
            string json = await message.Content.ReadAsStringAsync();

            List<StarWarsCharacter> characters = JsonConvert.DeserializeObject<List<StarWarsCharacter>>(json);
            return characters;
        }
    }
}