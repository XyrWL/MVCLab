using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_4_Exercise2.Models;

namespace Lab_4_Exercise2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            using (SchoolContext context = new SchoolContext())
                return View(context.Students.ToList());
        }
       
        public ActionResult Details(int id)
        {
            using (SchoolContext context = new SchoolContext())
                return View(context.Students.Find(id));
        }
    }
}