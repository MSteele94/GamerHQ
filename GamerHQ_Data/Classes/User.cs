using GamerHQ_Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Data
{
    public class User
    {
        public enum PlatformType { Playstation, Xbox, PC, Switch, Mobile }
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        [Required]
        public string GamerTag { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [DefaultValue(false)]
        public bool WantsCrossplay { get; set; }

        public virtual ICollection<JoiningTable> JoiningTables { get; set; } = new List<JoiningTable>();
        //public virtual ICollection<GameListItem> GameListItems { get; set; } = new List<GameListItem>();

        //public virtual ICollection<Game> Games { get; set; }
        //public virtual ICollection<Platform> Platforms { get; set; }
    }
}
