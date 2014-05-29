using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolManagement.Manager;
using SchoolManagement.Model;

namespace SchoolManagement.RestService.Controllers
{
    public class StudentController : ApiController
    {
        public List<Student> Get()
        {
            StudentManager manager = new StudentManager();
            List<Student> students = manager.GetStudents();
            return students;
        }


        public bool Post(Student student)
        {
            StudentManager manager = new StudentManager();
             manager.Add(student);
             return true;
        }

    }
}
