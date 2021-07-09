using Hello_Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Hello_Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}