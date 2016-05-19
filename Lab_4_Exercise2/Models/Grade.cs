using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_4_Exercise2.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        [DisplayName("Course Name")]
        public string CourseName { get; set; }

        [DisplayName("Grade")]
        public string GradeValue { get; set; }
        
        public virtual int StudentId { get; set; }
    }
}