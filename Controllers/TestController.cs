using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Db_Operations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Db_Operations.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {

            List<Student> students = new List<Student>();
            students.Add(new Student() { RollNO=1,Name="Vishnu"});
            students.Add(new Student() { RollNO = 2, Name = "Manu" });
            students.Add(new Student() { RollNO = 3, Name = "Vishnukumar" });

            students.Add(new Student() { RollNO = 4, Name = "Vishnu" });
            students.Add(new Student() { RollNO = 5, Name = "Vishnu" });
            students.Add(new Student() { RollNO = 6, Name = "Vishnu" });

            students.Add(new Student() { RollNO = 7, Name = "Vishnu" });

            students.Add(new Student() { RollNO = 8, Name = "Vishnu" });
            return View(students);
        }

        public IActionResult Add()
        {
            return View();
        }


    }
}