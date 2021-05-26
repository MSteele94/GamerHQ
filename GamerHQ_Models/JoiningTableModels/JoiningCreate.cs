using GamerHQ_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Models.JoiningTableModels
{
    public class JoiningCreate
    {
        public int ID { get; set; }

        public int UserID { get; set; }
        public int GameID { get; set; }
        public virtual Game Games { get; set; }
    }
}
