using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ElVegetarianoFurio.Menu;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElVegetarianoFurio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {

        public ICommand CallNowCommand => new Command(CallNow);

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("menu/dish", typeof(DetailsPage));
        }

        private void CallNow()
        {
            PhoneDialer.Open("0123456789");
        }
    }
}