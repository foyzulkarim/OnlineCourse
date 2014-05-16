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
            var list = (from product in products
                where product.Price > 10
                orderby product.Price
                select
                    new // type?? annonymous type. 
                    {
                        Name = product.Name,
                        Code = product.Code,
                        Price = product.Price,
                        Category = product.Category.Name,
                        Group = product.Category.Group.Name
                    }
                ).ToList();


            double sum = 0;
            foreach (var v in list)
            {
                sum += v.Price;
            }

            double d = list.Sum(p=>p.Price);
            double max = list.Max(p => p.Price);

            products.First(p => p.Id == 10);
     //test line       
            Console.Read();
        }
    }
}
