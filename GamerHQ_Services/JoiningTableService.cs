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
                    Users = model.Users,
                    Game = model.Games
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.JoiningTables.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
