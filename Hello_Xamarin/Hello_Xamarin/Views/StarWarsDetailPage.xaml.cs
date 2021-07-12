using Hello_Xamarin.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarWarsDetailPage : ContentPage
    {
        public StarWarsDetailPage()
        {
            InitializeComponent();
            BindingContext = new StarWarsDetailViewModel();
        }
    }
}