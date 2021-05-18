using GamerHQ.Data;
using GamerHQ_Data;
using GamerHQ_Models.GameModels;
using GamerHQ_Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.User;

namespace GamerHQ_Services
{
    public class UserService
    {
        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    //Need to add PlatformType Enum and GameListItem ICollection to user class/ implement them into this method somehow
                    Name = model.Name,
                    GamerTag = model.GamerTag,
                    Email = model.Email,
                    Age = model.Age,
                    PlatformTypes = model.PlatformTypes
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.UsersInfo.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<UserListItem> GetUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .UsersInfo
                    .Select(
                        e =>
                        new UserListItem
                        {
                            UserID = e.UserID,
                            Name = e.Name,
                            GamerTag = e.GamerTag,
                            Email = e.Email,
                            Age = e.Age,
                            PlatformType = e.PlatformTypes,
                            WantsCrossplay = e.WantsCrossplay
                        }
                        );
                return query.ToArray();
            }
        }
        public UserDetail GetUserById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UsersInfo
                    .Single(e => e.UserID == id);
                List<GameListItem> gameList = new List<GameListItem>();
                foreach (var game in entity.JoiningTables)
                {
                    var gameListItem = new GameListItem()
                    {
                        GameID = game.Game.GameID,
                        GameName = game.Game.GameName
                    };
                    gameList.Add(gameListItem);
                }
                return
                new UserDetail
                {
                    UserID = entity.UserID,
                    Name = entity.Name,
                    GamerTag = entity.GamerTag,
                    Email = entity.Email,
                    Age = entity.Age,
                    PlatformType = entity.PlatformTypes,
                    GameListItems = gameList
                };
            }
        }
        public bool UpdateUser(UserEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UsersInfo
                    .Single(e => e.UserID == model.UserID);
                entity.UserID = model.UserID;
                entity.Name = model.Name;
                entity.GamerTag = model.GamerTag;
                entity.Email = model.Email;
                entity.Age = model.Age;
                entity.PlatformTypes = model.PlatformType;
                entity.WantsCrossplay = model.WantsCrossplay;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteUser(int userID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                 ctx
                 .UsersInfo
                 .Single(e => e.UserID == userID);
                ctx.UsersInfo.Remove(entity);

                return ctx.SaveChanges() == 1;

            }
        }
    }
}
