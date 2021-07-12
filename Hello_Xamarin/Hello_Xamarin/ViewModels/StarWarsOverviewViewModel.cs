using Hello_Xamarin.Models;
using Hello_Xamarin.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello_Xamarin.ViewModels
{
    public class StarWarsOverviewViewModel : BaseViewModel
    {
        private StarWarsService starWarsService;

        public ObservableCollection<StarWarsCharacter> Characters { get; set; }
            = new ObservableCollection<StarWarsCharacter>();

        public Command LoadItemsCommand { get; }
        public Command ItemTapped { get; }

        public StarWarsOverviewViewModel()
        {
            starWarsService = new StarWarsService();
            LoadItemsCommand = new Command(async () => await ExecuteLoadCharacters());
            ItemTapped = new Command<StarWarsCharacter>(OnItemSelected);
        }

        private async Task ExecuteLoadCharacters()
        {
            IsBusy = true;
            Characters.Clear();

            List<StarWarsCharacter> characters = await starWarsService.GetStarWarsCharacters();

            foreach (var character in characters)
            {
                character.image = $"https://starwars.egghead.training/{character.image}";
                Characters.Add(character);
            }

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async void OnItemSelected(StarWarsCharacter character)
        {
            // TODO: Add navigation
        }
    }
}