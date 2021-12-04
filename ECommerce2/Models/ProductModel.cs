using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce2.Models
{
    public class ProductModel
    {
        private List<Product> ProductList;

        public ProductModel()
        {
            ProductList = new List<Product>() {
                new Product
                {
                   Product_ID = 1 ,
                   Product_Name = "Apple",
                   Product_Price = 2.00,
                   Product_Description = "Crisp Apple",
                   Product_Photo = "apple.jpg"
                },
                new Product
                {
                   Product_ID = 2 ,
                   Product_Name = "Orange",
                   Product_Price = 1.00,
                   Product_Description = "Sweet Orange",
                   Product_Photo = "orange.jpg"
                },
                new Product
                {
                   Product_ID = 3 ,
                   Product_Name = "Pear",
                   Product_Price = 3.00,
                   Product_Description = "Juicy Pear",
                   Product_Photo = "pear.jpg"
                }
            };
        }

        public List<Product> findAll()
        {
            return ProductList;
        }

        public Product find(int id)
        {
            return ProductList.Where(p => p.Product_ID == id).FirstOrDefault();
        }
    }
}
