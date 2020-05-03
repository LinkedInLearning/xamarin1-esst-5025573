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
    public partial class BebidasPage : ContentPage
    {
        private CategoryViewModel _viewModel;
        public BebidasPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel(6);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadDataCommand.Execute(null);
        }
    }
}