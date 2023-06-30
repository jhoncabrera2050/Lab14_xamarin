using Lab14.Models;
using Lab14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProductPage : ContentPage
    {
        public Productinfo Productinfo { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
        }
    }
}