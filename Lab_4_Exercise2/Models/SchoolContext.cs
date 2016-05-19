using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab_4_Exercise2.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public SchoolContext() : base("SchoolDB")
        {
            Database.SetInitializer(new SchoolInitializer());
        }
    }

    public class SchoolInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>()
            {
               new Student
               {
                   StudentId = 0,
                   Name = "Jimmy",
                   Lastname = "Haridy",
                   Address = "Somewhere in Helsingborg",
                   Personnumber = "123456-1234",
                   Grades = new List<Grade>
                   {
                       new Grade {GradeId = 0, CourseName = "C#", GradeValue = "VG"},
                       new Grade {GradeId = 1, CourseName = "Java", GradeValue = "G"}
                   }
               },
               new Student
               {
                   StudentId = 1,
                   Name = "Ivan",
                   Lastname = "Prgomet",
                   Address = "Somewhere north of Helsinborg",
                   Personnumber = "654321-4321",
                   Grades = new List<Grade>
                   {
                       new Grade {GradeId = 2, CourseName = "C", GradeValue = "G"},
                       new Grade {GradeId = 3, CourseName = "VB", GradeValue = "VG"}
                   }
               }
            };
            foreach (var student in students)
                context.Students.Add(student);
            context.SaveChanges();
        }
    }
}