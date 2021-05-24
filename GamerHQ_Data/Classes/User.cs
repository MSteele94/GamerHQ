using GamerHQ_Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.PlatformEnum;

namespace GamerHQ_Data
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        [Required]
        public string GamerTag { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        
        public bool WantsCrossplay { get; set; }
        public PlatformType PlatformTypes { get; set; }
        public virtual ICollection<JoiningTable> JoiningTables { get; set; } = new List<JoiningTable>();
        //public virtual ICollection<GameListItem> GameListItems { get; set; } = new List<GameListItem>();

       
    }
}
