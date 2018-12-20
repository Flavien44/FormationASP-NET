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
            return View(new DetailViewModel
            {
                Student = new Student
                {
                    Name = "Contoso Jon",
                    Class = 1,
                    Email = "12345@gmail.com",
                    HasPaid = true
                },
                School = "INFO"
            });
        }
    }
}