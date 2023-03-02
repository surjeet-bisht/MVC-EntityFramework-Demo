
using MVC_EntityFramework_Demo.Data;
using MVC_EntityFramework_Demo.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_EntityFramework_Demo.Services
{
    public class StudentService
    {
        MVCDemoEntities _dbContext;
        public StudentService()
        {
            _dbContext = new MVCDemoEntities();
        }
        public List<Student> StudentList()
        {
            return _dbContext.Students.ToList();
        }
        public Boolean SaveStudent(Student studentModel)
        {
            _dbContext.Students.Add(studentModel);
            _dbContext.SaveChanges();
            return true;
        }
        

    }
}
