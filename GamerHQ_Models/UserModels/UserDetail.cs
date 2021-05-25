using GamerHQ_Data.Classes;
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
    public class UserDetail
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string GamerTag { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public PlatformType PlatformType { get; set; }
        public GenreType Genres { get; set; }

        public bool WantsCrossplay { get; set; }
        public virtual ICollection<JoiningTable> JoiningTables { get; set; } = new List<JoiningTable>();

    }
}
