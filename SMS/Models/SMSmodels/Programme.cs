using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SMSmodels
{
    public class Programme
    {
        [Key]
        [MaxLength(100)]
        [Required]
        public string ProgrammeName { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public Department Department { get; set; }
        public List<Course> Courses { get; set; }
    }
}