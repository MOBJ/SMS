using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SMSmodels
{
    public class Department
    {
        [Key]
        [MaxLength(100)]
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string FacultyName { get; set; }
        public Faculty Faculty { get; set; }
        public List<Programme> Programmes { get; set; }
    }
}