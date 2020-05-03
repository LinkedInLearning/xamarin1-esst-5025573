using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElVegetarianoFurio.Menu;
using Xamarin.Forms;

namespace ElVegetarianoFurio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadDataCommand.Execute(null);
        }

        async void OnCategorySelected(object sender, SelectionChangedEventArgs e)
        {
            var id = (e.CurrentSelection.FirstOrDefault() as Category).Id;
            string route;

            switch (id)
            {
                case 1:
                    route = "///menu/ensaladas";
                    break;
                case 2:
                    route = "///menu/sopas";
                    break;
                case 3:
                    route = "///menu/tapas";
                    break;
                case 4:
                    route = "///menu/principales";
                    break;
                case 5:
                    route = "///menu/postres";
                    break;
                case 6:
                    route = "///menu/bebidas";
                    break;
                default:
                    route = "start";
                    break;
            }

            await Shell.Current.GoToAsync(route);

        }
    }
}
