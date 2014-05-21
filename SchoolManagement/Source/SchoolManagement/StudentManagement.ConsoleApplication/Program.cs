using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Manager;
using SchoolManagement.Model;

namespace StudentManagement.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            manager.Delete(1);
            Console.WriteLine("Current student count : " + manager.GetStudents().Count);
            Console.ReadLine();
        }
    }
}
