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
            DataProvider.GetProducts()
                .ForEach(prod => Console.WriteLine(String.Format("Product Name : {0}, Price : {1}, Category : {2}, Group : {3}",
                    prod.Name, prod.Price, prod.Category.Name, prod.Category.Group.Name)));
            Console.Read();
        }
    }
}
