using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Data.Classes
{
    public class Platform
    {
        public enum PlatformType { Playstation, Xbox, PC, Switch, Mobile }
        [Key]
        public int PlatformID { get; set; }
        
        public virtual ICollection<JoiningTable> JoiningTables { get; set; }
    }
}
