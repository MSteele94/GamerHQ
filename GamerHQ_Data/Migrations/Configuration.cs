namespace GamerHQ_Data.Migrations
{
    using GamerHQ.Data;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static GamerHQ_Data.Classes.PlatformEnum;

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
              new Game { GameName = "League of Legends", GenreType = GenreType.MMORPG, CreatedUtc = DateTimeOffset.UtcNow },
              new Game { GameName = "CSGO", GenreType = GenreType.Shooter, CreatedUtc = DateTimeOffset.UtcNow },
              new Game { GameName = "Outriders", GenreType = GenreType.OpenWorld, CreatedUtc = DateTimeOffset.UtcNow },
              new Game { GameName = "Destiny", GenreType = GenreType.Shooter, CreatedUtc = DateTimeOffset.UtcNow },
              new Game { GameName = "Call of Duty: Black Ops ColdWar" , GenreType = GenreType.Shooter, CreatedUtc = DateTimeOffset.UtcNow },
              new Game { GameName = "Rocket League", GenreType = GenreType.Action, CreatedUtc = DateTimeOffset.UtcNow },
              new Game { GameName = "Ark", GenreType = GenreType.Adventure, CreatedUtc = DateTimeOffset.UtcNow}

            );
            context.UsersInfo.AddOrUpdate(
                p => p.Name,
                new User { Name = "Michael", GamerTag = "FlyinZebrah", Email = "msteele94@gmail.com", Age =
                26, WantsCrossplay = true, PlatformTypes = PlatformType.Playstation, GenreType = GenreType.Shooter},
                new User { Name = "Addey", GamerTag = "AddeySucksAtLeague", Email = "IAmBadAtLeague@gmail.com", Age =
                32, WantsCrossplay = false, PlatformTypes = PlatformType.PC, GenreType = GenreType.MMORPG}
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
