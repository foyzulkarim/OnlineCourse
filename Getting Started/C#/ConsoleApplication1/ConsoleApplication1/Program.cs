using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // input a number
            string valueStr = Console.ReadLine();
            // convert the string to number
            int value = Convert.ToInt32(valueStr);
            // square that number
            int result = value*value;
            // show that number
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
