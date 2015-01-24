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
            Console.WriteLine("Please input first number: ");
            string firstNumStr = Console.ReadLine();         
            int first = Convert.ToInt32(firstNumStr);
            Console.WriteLine("Please input second number: ");
            string secondNumStr = Console.ReadLine();
            int second = Convert.ToInt32(secondNumStr);
            Console.WriteLine("The sum is: ");
            int sum = Calculator.Add(first, second);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
