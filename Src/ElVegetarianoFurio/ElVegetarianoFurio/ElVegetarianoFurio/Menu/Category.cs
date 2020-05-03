using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ElVegetarianoFurio.Menu
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ImageSource Image => ImageSource.FromResource($"ElVegetarianoFurio.Images.Categories.{Id}.jpg");
    }
}
