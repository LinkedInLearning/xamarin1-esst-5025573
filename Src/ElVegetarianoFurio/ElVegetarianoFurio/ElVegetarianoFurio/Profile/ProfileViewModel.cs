using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Essentials;

namespace ElVegetarianoFurio.Profile
{
    public class ProfileViewModel : INotifyPropertyChanged
    {


        public string FullName
        {
            get => Preferences.Get(nameof(FullName), "");
            set
            {
                Preferences.Set(nameof(FullName), value);
                OnPropertyChanged();
            }
        }

        public string Street
        {
            get => Preferences.Get(nameof(Street), "");
            set
            {
                Preferences.Set(nameof(Street), value);
                OnPropertyChanged();
            }
        }

        public string Zip
        {
            get => Preferences.Get(nameof(Zip), "");
            set
            {
                Preferences.Set(nameof(Zip), value);
                OnPropertyChanged();
            }
        }

        public string City
        {
            get => Preferences.Get(nameof(City), "");
            set
            {
                Preferences.Set(nameof(City), value);
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
