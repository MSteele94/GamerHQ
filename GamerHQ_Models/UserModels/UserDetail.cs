using GamerHQ_Data.Classes;
using GamerHQ_Models.GameModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.User;

namespace GamerHQ_Models.UserModels
{
    public class UserDetail
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string GamerTag { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public PlatformType PlatformType { get; set; }

        public bool WantsCrossplay { get; set; }
        [Display(Name="Pick a game you play")]
        public virtual ICollection<GameListItem> GameListItems { get; set; } = new List<GameListItem>();
    }
}
