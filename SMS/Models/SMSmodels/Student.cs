using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SMSmodels
{
    public class Student
    {
        [Key]
        [MaxLength(5)]
        [Required]
        public string MatricNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string OtherName { get; set; }
        [Required]
        public string ProgrammeName { get; set; }
        public Programme Programme { get; set; }
        [Required]
        public string GenderId { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "DOB",Prompt ="MM/DD/YYYY")]
        public DateTime DOB { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; }
        [MaxLength(50)]
        [Required]
        public string State_Of_Origin { get; set; }
        [Required]
        public int UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }
        [Required]
        public int YearId { get; set; }
        public Year Year { get; set; }
        [Required]
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }

    }
}