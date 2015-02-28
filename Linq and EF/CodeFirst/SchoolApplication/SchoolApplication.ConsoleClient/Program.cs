using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApplication.DataAccess;
using SchoolApplication.Model;

namespace SchoolApplication.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDataContext db = new SchoolDataContext();
            var students = db.Students.ToList();
            foreach (Student s in students)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
