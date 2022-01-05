using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.HomeworkSubmissions = new HashSet<Homework>();
            this.Recources = new HashSet<Resource>();
            this.StudentsEnrolled = new HashSet<StudentCourse>();
        }
        public int CourseId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //[Required]
       // [Column(TypeName = "decimal(18,2))"]
        public decimal Price { get; set; }

        public ICollection<Homework> HomeworkSubmissions { get; set; }

        public ICollection<Resource> Recources { get; set; }

        public ICollection<StudentCourse> StudentsEnrolled { get; set; }
    }
}
