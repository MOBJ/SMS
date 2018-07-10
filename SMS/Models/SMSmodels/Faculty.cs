using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SMSmodels
{
    public class Faculty
    {
        [Key]
        [MaxLength(100)]
        [Required]
        public string FacultyName { get; set; }
        public List<Department> Departments { get; set; }

    }
}