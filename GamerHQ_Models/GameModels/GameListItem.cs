using GamerHQ_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Game;

namespace GamerHQ_Models.GameModels
{
    public class GameListItem
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
       // public GameRating GameRating { get; set; }

        public ICollection<Game> Games { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
