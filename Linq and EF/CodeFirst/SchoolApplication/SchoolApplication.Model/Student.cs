using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
