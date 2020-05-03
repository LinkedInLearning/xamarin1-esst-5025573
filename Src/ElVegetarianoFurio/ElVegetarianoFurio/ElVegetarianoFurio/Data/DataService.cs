using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ElVegetarianoFurio.Menu;
using Newtonsoft.Json;

namespace ElVegetarianoFurio.Data
{
    public class DataService
    {
        private RestaurantData GetRestaurantData()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(DataService)).Assembly;

            var stream = assembly.GetManifestResourceStream("ElVegetarianoFurio.Data.db.json");

            string json;

            using(var reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            var data = JsonConvert.DeserializeObject<RestaurantData>(json);
            return data;
        }

        public List<Category> GetCategories()
        {
            var data = GetRestaurantData();
            return data.Categories;
        }

        public List<Dish> GetDishes(int? categoryId = null)
        {
            var dishes = GetRestaurantData().Dishes;
            
            if(categoryId.HasValue)
            {
                dishes = dishes.Where(d => d.CategoryId == categoryId).ToList();
            }

            return dishes;
        }

    }

    public class RestaurantData
    {
        public List<Category> Categories { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
