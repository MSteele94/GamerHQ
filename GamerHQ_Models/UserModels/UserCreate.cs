using GamerHQ_Models.GameModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.PlatformEnum;
using static GamerHQ_Data.User;

namespace GamerHQ_Models.UserModels
{
    public class UserCreate
    {
        //[Hidden]
        public int UserID { get; set; }
        public string Name { get; set; }
        [Required]
        public string GamerTag { get; set; }
        public PlatformType PlatformTypes { get; set; }

        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        public bool WantsCrossplay { get; set; }

        [Display(Name = "Pick a game you play")]
        public virtual ICollection<GameListItem> GameListItems { get; set; } = new List<GameListItem>();

    }
}
