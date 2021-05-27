using GamerHQ_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Models.JoiningTableModels
{
    public class JoiningEdit
    {
        public int ID { get; set; }
        public virtual User Users { get; set; }
        public virtual Game Games { get; set; }
    }
}
