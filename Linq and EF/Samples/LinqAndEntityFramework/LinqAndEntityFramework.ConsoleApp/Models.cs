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

    public static class DataProvider
    {
        public static List<Group> Groups { get; private set; }

        public static List<Category> Categories { get; private set; }

        static DataProvider()
        {
            DataProvider.Groups = new List<Group> {                 
                    new Group{ Id = 1, Name = "Drinks" },
                    new Group{ Id = 2, Name = "Main Dish" },
                    new Group{ Id = 3, Name = "Side Dish" },
                    new Group{ Id = 4, Name = "Starters" },
                    new Group{ Id = 5, Name = "Rices" },
                    new Group{ Id = 6, Name = "Breads" }                
            };

            DataProvider.Categories = new List<Category> { 
                new Category{ Id = 1, Group = GetGroup(1), Name = "Hot Drinks" },
                new Category{ Id = 2, Group = GetGroup(1), Name = "Cold Drinks" },
                new Category{ Id = 3, Group = GetGroup(2), Name = "Chinese" },
                new Category{ Id = 4, Group = GetGroup(2), Name = "Indian" },                
                new Category{ Id = 5, Group = GetGroup(3), Name = "Desert" },
                new Category{ Id = 6, Group = GetGroup(4), Name = "Appetizers" },
                new Category{ Id = 7, Group = GetGroup(5), Name = "Long Grain" },
                new Category{ Id = 8, Group = GetGroup(5), Name = "Short Grain" },
                new Category{ Id = 9, Group = GetGroup(6), Name = "Wheat" },
                new Category{ Id = 10, Group = GetGroup(6), Name = "Corn" }
            };
        }

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
            Group group = new Group();
            foreach (Group g in Groups)
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
            Category category = new Category();
            foreach (Category g in Categories)
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
            return new List<Product> { 
                new Product{ Id = 4, Name = "Shaan Bread", Code = "104", Price = 35.00, Category = GetCategory(9)  },
                new Product{ Id = 5, Name = "Well Foods", Code = "105", Price = 120.00, Category = GetCategory(9)  },
                new Product{ Id = 6, Name = "Cooper's", Code = "106", Price = 250.00, Category = GetCategory(10)  }
            };
        }

        private static List<Product> GetRices()
        {
            return new List<Product> { 
                new Product{ Id = 7, Name = "Basmati", Code = "107", Price = 300, Category = GetCategory(7) },
                new Product{ Id = 8, Name = "Minicat", Code = "108", Price = 280, Category = GetCategory(8) }
            };
        }

        private static List<Product> GetStarters()
        {
            return new List<Product> { 
                new Product{ Id = 9, Name = "Unthun", Code = "109", Price = 80, Category = GetCategory(6) }
            };
        }

        private static List<Product> GetSideDishes()
        {
            return new List<Product> {
                new Product{ Id = 10, Name = "Ice Cream", Code = "110", Price = 90, Category = GetCategory(5) },
                new Product{ Id = 11, Name = "Sweets", Code = "111", Price = 150, Category = GetCategory(5) }
            };
        }

        private static List<Product> GetMainDishes()
        {
            return new List<Product> { 
                new Product{ Id = 12, Name = "Fried Rice and Chicken", Code = "112", Price = 180, Category = GetCategory(3) },
                new Product{ Id = 13, Name = "Chola Batora", Code = "113", Price = 150, Category = GetCategory(4) },
                new Product{ Id = 14, Name = "Dosa", Code = "114", Price = 140, Category = GetCategory(4) }
            };
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
