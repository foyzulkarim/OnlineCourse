using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApplication.Model;

namespace SchoolApplication.DataAccess
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext(): base("SchoolDb")
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
