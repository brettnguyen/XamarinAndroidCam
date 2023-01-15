using System.ComponentModel;
using Xamarin.Forms;
using testingcam.ViewModels;

namespace testingcam.Views
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
