using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {

        // GET: Student
        public ActionResult Index()
        {
            var student = new Student
            {
                Name = "Contoso Jon",
                Class = 1,
                Email = "12345@gmail.com",
                HasPaid = true
            };
            return View(student);
        }

        public ActionResult Edit()
        {
            var s = new Student
            {
                Name = "Contoso Jon",
                Class = 1,
                Email = "12345@gmail.com",
                HasPaid = true
            };
            return View(s);
        }

        public ViewResult Detail()
        {
            var Student = TempData["student"] as Student;

            return View(new DetailViewModel
            {
                Student = Student ?? new Student
                {
                    Name = "Contoso Jon",
                    Class = 1,
                    Email = "12345@gmail.com",
                    HasPaid = true
                },
                School = "INFO"
            });
        }

        public ViewResult Create()
        {
            return View(new CreateViewModel
            {
                Student = new Student()
                {
                    JoinDate = DateTime.Now,
                    HasPaid = false,
                    StudentID = new Random().Next()
                }
            });
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel createviewmodel)
        {
            if (ModelState.IsValid)
            {
                TempData["student"] = createviewmodel.Student;

                return RedirectToAction("Detail");
            }
            else
            {
                return View(createviewmodel);
            }
        }
    }
}