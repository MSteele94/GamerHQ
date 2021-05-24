namespace GamerHQ_Data.Migrations
{
    using GamerHQ.Data;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamerHQ.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GamerHQ.Data.ApplicationDbContext";
        }

        protected override void Seed(GamerHQ.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            
            if (userManager.FindByEmail("ghqadmin@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "ghqadmin@gmail.com",
                    UserName = "ghqadmin@gmail.com"
                };

                var result = userManager.Create(user, "Test1!");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.UserName).Id, "Admin");
            }


        }
    }
}
