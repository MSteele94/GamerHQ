using GamerHQ_Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public virtual ICollection<JoiningTable> JoiningTables { get; set; }
        //public virtual ICollection<Game> Games { get; set; }
        //public virtual ICollection<Platform> Platforms { get; set; }
    }
}
