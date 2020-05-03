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
    public partial class SopasPage : ContentPage
    {
        private CategoryViewModel _viewModel;
        public SopasPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel(2);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadDataCommand.Execute(null);
        }
    }
}