using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_EntityFramework_Demo.Services.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
