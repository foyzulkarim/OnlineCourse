using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndEntityFramework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = DataProvider.GetProducts();
            foreach (Product product in products)
            {
                Console.WriteLine(string.Format("Product Name : {0}, Price : {1}, Category : {2}, Group : {3}",
                    product.Name, product.Price, product.Category.Name, product.Category.Group.Name));

            }
            

            Console.Read();
        }
    }

}
