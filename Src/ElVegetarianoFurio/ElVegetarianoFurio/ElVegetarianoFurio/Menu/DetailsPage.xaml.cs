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
    [QueryProperty("DishId", "id")]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        public string DishId
        {
            set
            {
                if (int.TryParse(value, out var dishId))
                {
                    BindingContext = new DetailsPageViewModel(dishId);
                }
            }
        }
    }
}