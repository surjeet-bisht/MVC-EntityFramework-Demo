using MVC_EntityFramework_Demo.Data;
using MVC_EntityFramework_Demo.Services;
using MVC_EntityFramework_Demo.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EntityFramework_Demo.Controllers
{
    public class StudentController : Controller
    {
        StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }
        // GET: Student
        public ActionResult Index()
        {
           var model = _studentService.StudentList();
            return View(model);
        }
        public ActionResult SaveStudent(Student model)
        {
            _studentService.SaveStudent(model);
            return View();
        }
    }
}