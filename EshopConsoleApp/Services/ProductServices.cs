using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EshopConsoleApp.Models;

namespace EshopConsoleApp.Services
{
    class ProductServices : BaseModel
    {

        public List<ProductModel> Create()
        {
            var paperCategory = new CategoryModel
            {
                Name = "Paper",
                Description = "Paper for any drawings"
            };

            var pencilCategory = new CategoryModel
            {
                Name = "Pencils",
                Description = "Various types of pencils"
            };

            var blackPencils = new TegModel
            {
                Name = "BlackPencils",
                Description = "allows to draw with black lead pencils"

            };

            var oilPencils = new TegModel
            {
                Name = "OilPencils",
                Description = "allows to draw with oil pencils"

            };

            var automaticPencils = new TegModel
            {
                Name = "AutomaticPencils",
                Description = "allows to draw with automatic and collet pencils"

            };

            var products = new List<ProductModel>();
            products.Add(new ProductModel
            {
                Name = "watercolour paper",
                Description = "Paper for drawing with watercolours and watercolour pencils",
                Cost = 58.84F,
                Category = paperCategory,
                Teg = new List<TegModel> { blackPencils, oilPencils, automaticPencils }
            });

            products.Add(new ProductModel
            {
                Name = "ruled paper",
                Description = "Lined drawing paper",
                Cost = 13.50F,
                Category = paperCategory,
                Teg = new List<TegModel> { blackPencils, automaticPencils }
            });

            products.Add(new ProductModel
            {
                Name = "oil paint paper",
                Description = "Primed paper, not canvas",
                Cost = 362.73F,
                Category = paperCategory,
                Teg = new List<TegModel> { blackPencils, oilPencils, automaticPencils }
            });

            products.Add(new ProductModel
            {
                Name = "black lead pencils",
                Description = "Has a black graphite rod",
                Cost = 36.83F,
                Category = pencilCategory,
                Teg = new List<TegModel> { }
            });

            products.Add(new ProductModel
            {
                Name = "oil pencil",
                Description = "Has a wood-free base",
                Cost = 80.30F,
                Category = pencilCategory,
                Teg = new List<TegModel> { }
            });

            products.Add(new ProductModel
            {
                Name = "automatic pencil",
                Description = "Supports replaceble rods",
                Cost = 51.83F,
                Category = pencilCategory,
                Teg = new List<TegModel> { }
            });
            return products;

        }

        public List<ProductModel> Search(string searchProduct)
        {
   
            var products = this.Create();
            foreach (var s in products)
            {
                if (s.Name.ToLower() == searchProduct.ToLower())
                {
                    
                }
            }

            return products;
        }
    }
}
 