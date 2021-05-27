using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Data.Classes
{
    public class Enums
    {
        [Key]
        public int ID { get; set; }
        public enum PlatformType { Playstation = 1, Xbox, PC, Switch, Mobile }
        public enum GenreType { Shooter =1, MMORPG, Action, RolePlay, Fighting, Adventure, OpenWorld, Racing}
    }
}