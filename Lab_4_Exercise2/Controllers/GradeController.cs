using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_4_Exercise2.Models;

namespace Lab_4_Exercise2.Controllers
{
    public class GradeController : Controller
    {
        public PartialViewResult _ListForStudent(int studentId)
        {
            using (SchoolContext context = new SchoolContext())
                return PartialView(context.Students.Find(studentId).Grades.ToList());
        }

        public PartialViewResult _Create(int studentId)
        {
            return PartialView(new Grade { StudentId = studentId });
        }

        [HttpPost]
        public ActionResult _Create(Grade model)
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Students.Find(model.StudentId).Grades.Add(model);
                context.SaveChanges();
                return RedirectToAction("_ListForStudent", new { studentId = model.StudentId });
            }
        }
    }
}