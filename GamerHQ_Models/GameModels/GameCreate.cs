using GamerHQ_Data;
using GamerHQ_Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Game;

namespace GamerHQ_Models.GameModels
{
   public class GameCreate
    {
       
        public int GameID { get; set; }
        [Required]
        public string GameName { get; set; }
        //public GameRating GameRating { get; set; }
        public ICollection<Game> Games { get; set; }
        public virtual ICollection<JoiningTable> JoiningTables { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
