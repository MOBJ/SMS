using SMS.Models.SMSmodels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMS.Data
{
    public class SMScontext : DbContext
    {
        public SMScontext() : base("DefaultConnection")
        { }
        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<Year> Years { get; set; }
    }
}