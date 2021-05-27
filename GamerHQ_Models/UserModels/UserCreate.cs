using GamerHQ_Models.GameModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.Enums;
using static GamerHQ_Data.User;

namespace GamerHQ_Models.UserModels
{
    public class UserCreate
    {
        public int UserID { get; set; }
        [Display(Name= "Name(Optional)")]
        public string Name { get; set; }
        [Required]
        public string GamerTag { get; set; }

        [Display(Name = "Gaming Platform")]
        public PlatformType PlatformTypes { get; set; }
        [Display(Name= "Preferred Game Genre")]
        public GenreType Genres { get; set; }

        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        public bool WantsCrossplay { get; set; }

        public virtual ICollection<GameListItem> GameListItems { get; set; } = new List<GameListItem>();

    }
}
