namespace SMS.Migrations.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SMS.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SMS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(SMS.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            if (!roleManager.RoleExists("Guest"))
                roleManager.Create(new IdentityRole("Guest"));

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //  string[] emails = { "a@a.a", "g@g.g" };

            if (userManager.FindByEmail("a@a.a") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "a@a.a",
                    UserName = "a@a.a"
                };

                var result = userManager.Create(user, "P@$$w0rd");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
            }

            if (userManager.FindByEmail("b@b.b") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "b@b.b",
                    UserName = "b@b.b"
                };

                var result = userManager.Create(user, "P@$$w0rd");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
            }

            if (userManager.FindByEmail("c@c.c") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "c@c.c",
                    UserName = "c@c.c"
                };

                var result = userManager.Create(user, "P@$$w0rd");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
            }

            if (userManager.FindByEmail("d@d.d") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "d@d.d",
                    UserName = "d@d.d"
                };

                var result = userManager.Create(user, "P@$$w0rd");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
            }

            if (userManager.FindByEmail("g@g.g") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "g@g.g",
                    UserName = "g@g.g"
                };

                var result = userManager.Create(user, "P@$$w0rd");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Guest");
            }
        }
    }
}
