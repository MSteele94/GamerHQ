using GamerHQ.Data;
using GamerHQ_Data.Classes;
using GamerHQ_Models.JoiningTableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Services
{
   public class JoiningTableService
    {
        public bool CreateJoiningTable(JoiningCreate model)
        {
            var entity =
                new JoiningTable()
                {
                    UserID = model.UserID,
                    GameID = model.GameID

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.JoiningTables.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<JoiningListItem> GetJoiningTable()
        
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .JoiningTables
                    .Select(
                        e =>
                        new JoiningListItem
                        {
                            UserID = e.UserID,
                            User = e.Users,
                            GameID = e.GameID,
                            Game = e.Game,
                            GameName = ctx.Games.FirstOrDefault(x => x.GameID == e.GameID).GameName
                        }
                        );
                return query.ToArray();
            }
        }
        
    }
}
