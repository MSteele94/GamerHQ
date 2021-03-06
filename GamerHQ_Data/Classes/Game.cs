using GamerHQ_Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.PlatformEnum;

namespace GamerHQ_Data
{
    public class Game
    {

        [Key]
        public int GameID { get; set; }
        [Required]
        public string GameName { get; set; }
        public ICollection<Game> Games { get; set; }
        public virtual ICollection<JoiningTable> JoiningTables { get; set; }
        public GenreType GenreType { get; set; }

        //Possibly used to filter for games by newest or date added
        public DateTimeOffset? CreatedUtc { get; set; }
    }
}
