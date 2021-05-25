using GamerHQ.Data;
using GamerHQ_Data;
using GamerHQ_Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Services
{
    public class GameService
    {
        public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    GameID = model.GameID,
                    GameName = model.GameName,
                    Games = model.Games,
                    CreatedUtc = DateTimeOffset.Now,
                    JoiningTables = model.JoiningTables,
                    GenreType = model.Genres
                    
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<GameListItem> GetGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Games
                    .Select(
                    e =>
                    new GameListItem
                    {
                        GameID = e.GameID,
                        GameName = e.GameName,
                        Games = e.Games,
                        Genres = e.GenreType,
                        CreatedUtc = DateTimeOffset.Now
                    }
                    );
                return query.ToArray();
            }
        }
        public GameDetail GetGameById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Games
                    .Single(e => e.GameID == id);
                return
                    new GameDetail
                    {
                        GameID = entity.GameID,
                        GameName = entity.GameName,
                        Genres = entity.GenreType,
                        CreatedUtc = DateTimeOffset.Now
                    };
            }
        }
        public bool UpdateGame(GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Games
                    .Single(e => e.GameID == model.GameID);
                entity.GameID = model.GameID;
                entity.GameName = model.GameName;
                entity.GenreType = model.Genres;
                entity.CreatedUtc = DateTimeOffset.Now;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGame(int gameID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Games
                    .Single(e => e.GameID == gameID);

                ctx.Games.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
