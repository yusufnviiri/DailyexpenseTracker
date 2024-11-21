using attendance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Services
{
public class ProductService:IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            Product bread = new() { ProductName = "Bread", ProductId = 1, Cost = 6300 };
            Product sugar = new() { ProductName = "Kakira Sugar", ProductId = 2, Cost = 5400 };
            Product soap = new() { ProductName = "Mukwano Soap", ProductId = 3, Cost = 2100 };
            Product bottledwater = new() { ProductName = "Rwenzori water", ProductId = 4, Cost = 1000 };
            Product ream = new() { ProductName = "Duplex Ream", ProductId = 5, Cost = 29000 };
            Product books = new() { ProductName = "stoic Books", ProductId = 6, Cost = 740000 };

            List<Product> products = [bread, sugar, soap, ream, books, bottledwater];
            return products;
        }
        public void CreateProduct(Product product) { }
        public void UpdateProduct(Product product) { }
        public void DeleteProduct(Product product) { }

      

 
    }
}
