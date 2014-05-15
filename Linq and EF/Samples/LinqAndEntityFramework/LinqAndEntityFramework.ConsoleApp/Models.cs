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
            List<Product> drinksList = GetDrinks();
            List<Product> mainDishes = GetMainDishes();
            List<Product> sideDishes = GetSideDishes();
            List<Product> starters = GetStarters();
            List<Product> rices = GetRices();
            List<Product> breads = GetBreads();
            
            List<Product> products = new List<Product>();
            products.AddRange(drinksList);
            products.AddRange(mainDishes);
            products.AddRange(sideDishes);
            products.AddRange(starters);
            products.AddRange(rices);
            products.AddRange(breads);
            return products;
        }

        private static Group GetGroup( int id )
        {
            var groups = new List<Group> {
                new Group{ Id = 1, Name = "Drinks" },
                new Group{ Id = 2, Name = "Main Dish" },
                new Group{ Id = 3, Name = "Side Dish" },
                new Group{ Id = 4, Name = "Starters" },
                new Group{ Id = 5, Name = "Rices" },
                new Group{ Id = 6, Name = "Breads" }
            };

            Group group = new Group();
            foreach (Group g in groups)
            {
                if (g.Id==id)
                {
                    group = g;
                    break;
                }
            }
            return group;
        }

        private static Category GetCategory( int id )
        {
            var categories = new List<Category> { 
                new Category{ Id = 1, Group = GetGroup(1), Name = "Hot Drinks" },
                new Category{ Id = 2, Group = GetGroup(1), Name = "Cold Drinks" }
            };

            Category category = new Category();
            foreach (Category g in categories)
            {
                if (g.Id == id)
                {
                    category = g;
                    break;
                }
            }
            return category;
        }

        private static List<Product> GetBreads()
        {
            return new List<Product>();
        }

        private static List<Product> GetRices()
        {
            return new List<Product>();
        }

        private static List<Product> GetStarters()
        {
            return new List<Product>();
        }

        private static List<Product> GetSideDishes()
        {
            return new List<Product>();
        }

        private static List<Product> GetMainDishes()
        {
            return new List<Product>();
        }

        private static List<Product> GetDrinks()
        {
            return new List<Product> {
                new Product{ Id = 1, Name = "Coke", Code = "101", Price = 30.0, Category = GetCategory(1) },
                new Product{ Id = 2, Name = "Lassi", Code = "102", Price = 40.0, Category = GetCategory(2) },
                new Product{ Id = 3, Name = "Coffee", Code = "103", Price = 60.0, Category = GetCategory(1) }
            };
        }
    }
}
