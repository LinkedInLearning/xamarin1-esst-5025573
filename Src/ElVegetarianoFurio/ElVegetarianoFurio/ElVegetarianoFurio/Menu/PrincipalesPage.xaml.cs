using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElVegetarianoFurio.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalesPage : ContentPage
    {
        private CategoryViewModel _viewModel;
        public PrincipalesPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel(4);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadDataCommand.Execute(null);
        }

        async void OnDishSelcted(object sender, SelectionChangedEventArgs e)
        {
            var id = (e.CurrentSelection.FirstOrDefault() as Dish).Id;
            await Shell.Current.GoToAsync($"///menu/dish?id={id}");
        }
    }
}