using Hello_Xamarin.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarWarsOverviewPage : ContentPage
    {
        private StarWarsOverviewViewModel _viewModel;

        public StarWarsOverviewPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new StarWarsOverviewViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}