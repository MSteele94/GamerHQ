namespace GamerHQ_Data.Migrations
{
    using GamerHQ.Data;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static GamerHQ_Data.Classes.Enums;

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
            //  to avoid creating duplicatea seed data. E.g.

            context.Games.AddOrUpdate(
              p => p.GameName,
              new Game { GameName = "League of Legends", GenreType = GenreType.MMORPG, CreatedUtc = DateTime.Now },
              new Game { GameName = "CSGO", GenreType = GenreType.Shooter, CreatedUtc = DateTime.Now },
              new Game { GameName = "Outriders", GenreType = GenreType.OpenWorld, CreatedUtc = DateTime.Now },
              new Game { GameName = "Destiny", GenreType = GenreType.Shooter, CreatedUtc = DateTime.Now },
              new Game { GameName = "Call of Duty: Black Ops ColdWar", GenreType = GenreType.Shooter, CreatedUtc = DateTime.Now },
              new Game { GameName = "Rocket League", GenreType = GenreType.Action, CreatedUtc = DateTime.Now },
              new Game { GameName = "Ark", GenreType = GenreType.OpenWorld, CreatedUtc = DateTime.Now }
            );
            context.UsersInfo.AddOrUpdate(
                p => p.Name,
                new User { Name = "Michael", GamerTag = "FlyinZebrah", PlatformTypes = PlatformType.Playstation, GenreType = GenreType.Shooter, Age = 26, Email = "msteele94@gmail.com", WantsCrossplay = true},

                new User { Name = "Addey", GamerTag = "AddeySucksAtLeague", PlatformTypes = PlatformType.PC, GenreType = GenreType.MMORPG, Age = 32, Email = "IAmBadAtLeague", WantsCrossplay = false}
                );
            //
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //if (!roleManager.RoleExists("Admin"))
            //    roleManager.Create(new IdentityRole("Admin"));

            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //if (userManager.FindByEmail("ghqadmin@gmail.com") == null)
            //{
            //    var user = new ApplicationUser
            //    {
            //        Email = "ghqadmin@gmail.com",
            //        UserName = "ghqadmin@gmail.com"
            //    };

            //    var result = userManager.Create(user, "Test1!");

            //    if (result.Succeeded)
            //        userManager.AddToRole(userManager.FindByEmail(user.UserName).Id, "Admin");
            //}


        }
    }
}
