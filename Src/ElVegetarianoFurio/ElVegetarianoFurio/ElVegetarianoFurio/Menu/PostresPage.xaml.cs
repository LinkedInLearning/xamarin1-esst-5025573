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
    public partial class PostresPage : ContentPage
    {
        private CategoryViewModel _viewModel;
        public PostresPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel(5);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadDataCommand.Execute(null);
        }
    }
}