using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ElVegetarianoFurio.Profile
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private string _city;
        private string _zip;
        private string _street;
        private string _fullName;

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged();
            }
        }

        public string Street
        {
            get => _street;
            set
            {
                _street = value;
                OnPropertyChanged();
            }
        }

        public string Zip
        {
            get => _zip;
            set
            {
                _zip = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
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
