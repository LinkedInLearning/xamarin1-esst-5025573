using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ElVegetarianoFurio.Data;
using ElVegetarianoFurio.Menu;
using Xamarin.Forms;

namespace ElVegetarianoFurio
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand LoadDataCommand;

        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();


        public MainPageViewModel()
        {
            LoadDataCommand = new Command(LoadData);
        }


        private void LoadData()
        {
            Categories.Clear();
            var dataService = new DataService();
            var categories = dataService.GetCategories();

            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
