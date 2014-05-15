using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndEntityFramework.ConsoleApp
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Category> Categories { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }

    public class DataProvider
    {
        public static List<Product> GetProducts()
        {
            Group drinks = new Group() { Id = 1, Name = "Drinks" };
            Category coldDrinks = new Category() { Id = 1, Name = "Cold Drinks", Group = drinks };
            Category hotDrinks = new Category(){Id = 2, Name = "Hot Drinks", Group = drinks};
            Product coke = new Product() { Id = 1, Name = "Coke", Code = "101", Price = 30.0, Category = coldDrinks };
            Product lassi = new Product(){Id = 2,Name = "Lassi", Code = "102", Price = 40.0, Category = coldDrinks};            
            Product coffee = new Product() { Id = 3, Name = "Coffee", Code = "103", Price = 60.0, Category = hotDrinks };
            

            List<Product> products = new List<Product>();
            products.Add(lassi);
            products.Add(coke);
            products.Add(coffee);

            return products;
        }
    }
}
