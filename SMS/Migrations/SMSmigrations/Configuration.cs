namespace SMS.Migrations.SMSmigrations
{
    using SMS.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SMS.Data.SMScontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SMSmigrations";
        }

        protected override void Seed(SMS.Data.SMScontext context)
        {
            //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Years.AddOrUpdate(
                y => new { y.YearId }, DummyData.GetYears().ToArray());
            context.SaveChanges();

            context.UserStatuses.AddOrUpdate(
                u => new { u.UserStatusId }, DummyData.GetUserStatuses().ToArray());
            context.SaveChanges();

            context.Semesters.AddOrUpdate(
                s => new { s.SemesterId }, DummyData.GetSemesters().ToArray());
            context.SaveChanges();

            context.Genders.AddOrUpdate(
                g => g.GenderId, DummyData.GetGenders().ToArray());
            context.SaveChanges();

            context.Faculties.AddOrUpdate(
                f => f.FacultyName, DummyData.GetFaculties().ToArray());
            context.SaveChanges();

            context.Departments.AddOrUpdate(
                d => d.DepartmentName, DummyData.GetDepartments(context).ToArray()
                );
            context.Programmes.AddOrUpdate(
                p => p.ProgrammeName, DummyData.GetProgrammes(context).ToArray()
                );
            context.Students.AddOrUpdate(
                s => s.MatricNo, DummyData.GetStudents(context).ToArray()
                );



        }
    }
}
