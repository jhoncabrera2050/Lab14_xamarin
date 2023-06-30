using Lab14.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab14.Views
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