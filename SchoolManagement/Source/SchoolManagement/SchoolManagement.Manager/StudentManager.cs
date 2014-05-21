using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Model;

namespace SchoolManagement.Manager
{
    public class StudentManager
    {
        SchoolManagementDbEntities Db;

        public StudentManager()
        {            
            Db = new SchoolManagementDbEntities();
        }

        public void Add(Student student)
        {            
            DbSet<Student> students = Db.Students;            
            students.Add(student);            
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student s = Db.Students.FirstOrDefault(student => student.Id == id);
            if (s!=null)
            {
                Db.Students.Remove(s);
            }
            Db.SaveChanges();
        }
    }
}
