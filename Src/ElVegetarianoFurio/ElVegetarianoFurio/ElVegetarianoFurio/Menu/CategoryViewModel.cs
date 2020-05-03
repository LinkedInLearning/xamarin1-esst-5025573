using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ElVegetarianoFurio.Data;
using Xamarin.Forms;

namespace ElVegetarianoFurio.Menu
{
    public class CategoryViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly int _categoryId;
        private Category _category;
        public ICommand LoadDataCommand { get; }

        public ObservableCollection<Dish> Dishes { get; set; } = new ObservableCollection<Dish>();

        public Category Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }

        public CategoryViewModel(int categoryId)
        {
            _categoryId = categoryId;
            LoadDataCommand = new Command(LoadData);
        }


        private void LoadData()
        {
            Dishes.Clear();
            var dataService = new DataService();


            Category = dataService.GetCategories().First(c => c.Id == _categoryId);
            var dishes = dataService.GetDishes(_categoryId);

            foreach (var dish in dishes)
            {
                Dishes.Add(dish);
            }
        }



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
