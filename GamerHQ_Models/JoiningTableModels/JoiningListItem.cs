using GamerHQ_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Models.JoiningTableModels
{
    public class JoiningListItem
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int GameID { get; set; }
        public virtual Game Game { get; set; }
    }
}
