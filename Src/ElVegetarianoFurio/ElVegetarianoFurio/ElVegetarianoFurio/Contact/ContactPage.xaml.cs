using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ElVegetarianoFurio.Contact
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = "Germany",
                PostalCode = "53489",
                Locality = "Sinzig",
                Thoroughfare = "Barbarossastraße 2"
            };

            var options = new MapLaunchOptions
            {
                Name = "El Vegetariano Furio",
                NavigationMode = NavigationMode.Driving
            };
            Map.OpenAsync(placemark, options);
        }
    }
}