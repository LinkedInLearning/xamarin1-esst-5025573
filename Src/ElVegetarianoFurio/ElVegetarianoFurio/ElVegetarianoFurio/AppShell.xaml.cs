using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
            BindingContext = this;
        }

        private void CallNow()
        {
            PhoneDialer.Open("0123456789");
        }
    }
}