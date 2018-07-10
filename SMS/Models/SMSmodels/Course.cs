using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SMSmodels
{
    public class Course
    {
        
        public int CourseId { get; set; }
        [MaxLength(100)]
        [Required]
        public string CourseName { get; set; }
        [Required]
        public int CourseCode { get; set; }
        [Required]
        public int YearId { get; set; }
        public Year Year { get; set; }
        [Required] 
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
        [Required]
        public string ProgrammeName { get; set; }
        public Programme Programme { get; set; }
        
    }
}