using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMS.Models.SMSmodels;

namespace SMS.Data
{
    public class DummyData
    {
        public static List<Year> GetYears()
        {
            List<Year> years = new List<Year>()
            {
                new Year()
                {
                    YearName = "First",

                },
                new Year()
                {
                    YearName = "Second",

                },
                new Year()
                {
                    YearName = "Third",

                },
                new Year()
                {
                    YearName = "Fourth",

                },
                new Year()
                {
                    YearName = "Fifth",

                },
                new Year()
                {
                    YearName = "Sixth",

                }

            };
            return years;
        }

        public static List<UserStatus> GetUserStatuses()
        {
            List<UserStatus> userStatuses = new List<UserStatus>()
            {
                new UserStatus()
                {
                    //UserStatusId = 0,
                    UserStatusName = "InActive",

                },
                new UserStatus()
                {
                    //UserStatusId = 1,
                    UserStatusName = "Active",
                }

            };
            return userStatuses ;
        }

        public static List<Semester> GetSemesters()
        {
            List<Semester> semesters = new List<Semester>()
            {
                new Semester()
                {

                    SemesterName = "First",

                },
                new Semester()
                {
                    
                    SemesterName = "second",
                }

            };
            return semesters;
        }

        public static List<Gender> GetGenders()
        {
            List<Gender> genders = new List<Gender>()
            {
                new Gender()
                {
                    
                    GenderId = "Male",

                },
                new Gender()
                {
                    GenderId = "Female",
                    
                }

            };

            return genders;
        }

        public static List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>()
            {
                new Faculty()
                {

                    FacultyName = "Engineering",

                },
                new Faculty()
                {
                    FacultyName = "Agriculture",

                },
                new Faculty()
                {
                    FacultyName = "Health Science",
                }

            };

            return faculties ;
        }

        public static List<Department> GetDepartments(SMScontext context)
        {
            List<Department> departments = new List<Department>()
            {
                new Department()
                {

                    DepartmentName = "Electrical",
                    FacultyName = context.Faculties.Find("Engineering").FacultyName,
                },

                new Department()
                {

                    DepartmentName = "School of medical Sciences",
                    FacultyName = context.Faculties.Find("Health Science").FacultyName,
                },

                new Department()
                {

                    DepartmentName = "Agricultural Management",
                    FacultyName = context.Faculties.Find("Agriculture").FacultyName,
                },
            };

            return departments;
        }

        public static List<Programme> GetProgrammes(SMScontext context)
        {
            List<Programme> programmes = new List<Programme>()
            {
                new Programme()
                {

                    ProgrammeName = "Human Biology",
                    DepartmentName = context.Departments.Find("School Of Medical Sciences").DepartmentName,
                },

                new Programme()
                {

                    ProgrammeName = "Electrical and Electronics",
                    DepartmentName = context.Departments.Find("Electrical").DepartmentName,
                },

                new Programme()
                {

                    ProgrammeName = "Agricultural Management",
                    DepartmentName = context.Departments.Find("Agricultural management").DepartmentName,
                },
            };

            return programmes;
        }

        public static List<Student> GetStudents(SMScontext context)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    MatricNo = "ENG01",
                    FirstName = "Bashir",
                    LastName = "Salihu",
                    
                    ProgrammeName = context.Programmes.Find("Electrical and Electronics").ProgrammeName,
                    GenderId = context.Genders.Find("Male").GenderId,
                    DOB = new DateTime(1995,5,22),
                    Nationality = "Nigerian",
                    State_Of_Origin = "Ekiti",
                    UserStatusId = context.UserStatuses.Find(0).UserStatusId,
                    YearId = context.Years.Find(3).YearId,
                    SemesterId = context.Semesters.Find(1).SemesterId,

                },
             

                new Student()
                {

                    MatricNo = "HBO01",
                    FirstName = "Ada",
                    LastName = "Adeolu",
                    OtherName = "Kemi",
                    ProgrammeName = context.Programmes.Find("Human Biology").ProgrammeName,
                    GenderId = context.Genders.Find("Female").GenderId,
                    DOB = new DateTime(1997,10,15),
                    Nationality = "Nigerian",
                    State_Of_Origin = "Lagos",
                    UserStatusId = context.UserStatuses.Find(1).UserStatusId,
                    YearId = context.Years.Find(1).YearId,
                    SemesterId = context.Semesters.Find(1).SemesterId,
                },

                new Student()
                {

                    MatricNo = "AGR01",
                    FirstName = "Josh",
                    LastName = "Mongoose",
                    OtherName = "Mouztee",
                    ProgrammeName = context.Programmes.Find("Agricultural Management").ProgrammeName,
                    GenderId = context.Genders.Find("Male").GenderId,
                    DOB = new DateTime(1996,3,11),
                    Nationality = "Nigerian",
                    State_Of_Origin = "Edo",
                    UserStatusId = context.UserStatuses.Find(1).UserStatusId,
                    YearId = context.Years.Find(4).YearId,
                    SemesterId = context.Semesters.Find(1).SemesterId,                },
            };

            return students;
        }


    }
}