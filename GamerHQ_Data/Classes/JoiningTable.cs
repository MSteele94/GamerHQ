using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Data.Classes
{
    public class JoiningTable
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserID { get; set; }
        public virtual User Users { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameID { get; set; }
        public virtual Game Game { get; set; }
    }
}
