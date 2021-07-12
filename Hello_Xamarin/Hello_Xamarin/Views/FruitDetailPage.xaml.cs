using Hello_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitDetailPage : ContentPage
    {
        public FruitDetailPage()
        {
            InitializeComponent();
            BindingContext = new FruitDetailViewModel();
        }
    }
}