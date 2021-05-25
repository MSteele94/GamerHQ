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
    public class UserListItem
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string GamerTag { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public PlatformType PlatformType { get; set; }
        [Display(Name="Preferred Game Genre")]
        public GenreType Genres { get; set; }

        [UIHint("Starred")]
        [Display(Name= "Allows Crossplay")]
        public bool WantsCrossplay { get; set; }

    }
}
