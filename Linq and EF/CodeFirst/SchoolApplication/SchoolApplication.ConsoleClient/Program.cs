using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            using (SchoolDataContext db = new SchoolDataContext())
            {
                Console.WriteLine("Update a new student. ");
                Student student = new Student();
                Console.WriteLine("Write the Id");
                student.StudentId = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Write name: ");
                //student.Name = Console.ReadLine();
                //Console.WriteLine("Write address: ");
                //student.Address = Console.ReadLine();
                //Console.WriteLine("Write phone: ");
                //student.Phone = Console.ReadLine();
               
                db.Students.Attach(student);
                db.Entry(student).State = EntityState.Deleted;                
                db.SaveChanges();

                DisplayStudents(db.Students.ToList());
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void DisplayStudents(List<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
