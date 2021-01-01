using System;
using System.Collections.Generic;
using System.Text;

namespace EshopConsoleApp.Models
{
    class ProductModel : BaseModel
    {

        public string Picture { get; set; }

        public float Cost { get; set; }

        public CategoryModel Category { get; set; }

        public List<TegModel> Teg { get; set; }

    }
}
