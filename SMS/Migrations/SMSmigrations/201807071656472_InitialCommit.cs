namespace SMS.Migrations.SMSmigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false, maxLength: 100),
                        CourseCode = c.Int(nullable: false),
                        YearId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        ProgrammeName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Programmes", t => t.ProgrammeName, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: true)
                .ForeignKey("dbo.Years", t => t.YearId, cascadeDelete: true)
                .Index(t => t.YearId)
                .Index(t => t.SemesterId)
                .Index(t => t.ProgrammeName);
            
            CreateTable(
                "dbo.Programmes",
                c => new
                    {
                        ProgrammeName = c.String(nullable: false, maxLength: 100),
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ProgrammeName)
                .ForeignKey("dbo.Departments", t => t.DepartmentName, cascadeDelete: true)
                .Index(t => t.DepartmentName);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                        FacultyName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.DepartmentName)
                .ForeignKey("dbo.Faculties", t => t.FacultyName, cascadeDelete: true)
                .Index(t => t.FacultyName);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.FacultyName);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        SemesterId = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.SemesterId);
            
            CreateTable(
                "dbo.Years",
                c => new
                    {
                        YearId = c.Int(nullable: false, identity: true),
                        YearName = c.String(),
                    })
                .PrimaryKey(t => t.YearId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        MatricNo = c.String(nullable: false, maxLength: 5),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        OtherName = c.String(maxLength: 50),
                        ProgrammeName = c.String(nullable: false, maxLength: 100),
                        GenderId = c.String(nullable: false, maxLength: 128),
                        DOB = c.DateTime(nullable: false),
                        Nationality = c.String(nullable: false, maxLength: 50),
                        State_Of_Origin = c.String(nullable: false, maxLength: 50),
                        UserStatusId = c.String(nullable: false, maxLength: 128),
                        YearId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatricNo)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Programmes", t => t.ProgrammeName, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: true)
                .ForeignKey("dbo.UserStatus", t => t.UserStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Years", t => t.YearId, cascadeDelete: true)
                .Index(t => t.ProgrammeName)
                .Index(t => t.GenderId)
                .Index(t => t.UserStatusId)
                .Index(t => t.YearId)
                .Index(t => t.SemesterId);
            
            CreateTable(
                "dbo.UserStatus",
                c => new
                    {
                        UserStatusId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.UserStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "YearId", "dbo.Years");
            DropForeignKey("dbo.Students", "UserStatusId", "dbo.UserStatus");
            DropForeignKey("dbo.Students", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Students", "ProgrammeName", "dbo.Programmes");
            DropForeignKey("dbo.Students", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Courses", "YearId", "dbo.Years");
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Programmes", "DepartmentName", "dbo.Departments");
            DropForeignKey("dbo.Departments", "FacultyName", "dbo.Faculties");
            DropForeignKey("dbo.Courses", "ProgrammeName", "dbo.Programmes");
            DropIndex("dbo.Students", new[] { "SemesterId" });
            DropIndex("dbo.Students", new[] { "YearId" });
            DropIndex("dbo.Students", new[] { "UserStatusId" });
            DropIndex("dbo.Students", new[] { "GenderId" });
            DropIndex("dbo.Students", new[] { "ProgrammeName" });
            DropIndex("dbo.Departments", new[] { "FacultyName" });
            DropIndex("dbo.Programmes", new[] { "DepartmentName" });
            DropIndex("dbo.Courses", new[] { "ProgrammeName" });
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropIndex("dbo.Courses", new[] { "YearId" });
            DropTable("dbo.UserStatus");
            DropTable("dbo.Students");
            DropTable("dbo.Genders");
            DropTable("dbo.Years");
            DropTable("dbo.Semesters");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.Programmes");
            DropTable("dbo.Courses");
        }
    }
}
