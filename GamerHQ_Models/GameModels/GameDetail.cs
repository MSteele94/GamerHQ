using GamerHQ_Data;
using GamerHQ_Models.UserModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.PlatformEnum;
using static GamerHQ_Data.Game;

namespace GamerHQ_Models.GameModels
{
    public class GameDetail
    {
        public int GameID { get; set; }
        public string GameName { get; set; }

        [Display(Name = "Genre")]

        public GenreType Genres { get; set; }

        public virtual ICollection<UserListItem> UserListItems { get; set; }
        public DateTimeOffset? CreatedUtc { get; set; }
    }
}
