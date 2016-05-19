using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Lab_4_Exercise2.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        [DisplayName("Last Name")]
        public string Lastname { get; set; }

        [DisplayName("Person Number")]
        public string Personnumber { get; set; }

        public string Address { get; set; }

        public virtual List<Grade> Grades { get; set; }
    }
}