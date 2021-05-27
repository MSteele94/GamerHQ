using GamerHQ_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.Enums;
using static GamerHQ_Data.Game;

namespace GamerHQ_Models.GameModels
{
    public class GameListItem
    {
        public int GameID { get; set; }
        public string GameName { get; set; }

        [Display(Name = "Genre")]
        public GenreType Genres { get; set; }

        public ICollection<Game> Games { get; set; }
        public DateTimeOffset? CreatedUtc { get; set; }

    }
}
