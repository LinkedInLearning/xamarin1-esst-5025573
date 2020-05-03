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
    public partial class TapasPage : ContentPage
    {
        private CategoryViewModel _viewModel;
        public TapasPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel(3);
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