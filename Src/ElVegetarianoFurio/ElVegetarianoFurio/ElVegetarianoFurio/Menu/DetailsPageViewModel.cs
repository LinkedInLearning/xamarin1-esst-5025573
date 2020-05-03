using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ElVegetarianoFurio.Data;

namespace ElVegetarianoFurio.Menu
{
    public class DetailsPageViewModel : INotifyPropertyChanged
    {

        private Dish _dish;
        public event PropertyChangedEventHandler PropertyChanged;

        public DetailsPageViewModel(int id)
        {
            var dataService = new DataService();
            Dish = dataService.GetDishes().First(d => d.Id == id);
        }

        public Dish Dish
        {
            get
            {
                return _dish;
            }
            set
            {
                _dish = value;
                OnPropertyChanged();
            }
        }




        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
