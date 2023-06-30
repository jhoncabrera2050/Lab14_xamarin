using Lab14.Models;
using Lab14.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab14.ViewModels
{
    public class ProductViewModel : BaseProductViewModel
    {
        public Command LoadProductCommand { get; }
        public ObservableCollection<Productinfo> Productinfos { get; }

        public Command AddProductCommad { get; }
        public ProductViewModel()
        {
            LoadProductCommand = new Command(async()=>await ExecuteLoadProductCommand());
            Productinfos = new ObservableCollection<Productinfo>();
            AddProductCommad = new Command(OnAddProduct);
        }
        public void OnAppearing()
        {
            IsBussy = true;
        }


        async Task ExecuteLoadProductCommand()
        {
            IsBussy = true;
            try
            {
                Productinfos.Clear();
                var prodList = await App.ProductService.GetProductAsyn();
                foreach (var prod in prodList)
                {
                    Productinfos.Add(prod);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBussy = false;
            }


        }
        private async void OnAddProduct(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AddProductPage));
        }
    }
}
