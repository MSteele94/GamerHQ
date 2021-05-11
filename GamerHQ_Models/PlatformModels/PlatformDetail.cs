using GamerHQ_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamerHQ_Data.Classes.Platform;

namespace GamerHQ_Models.PlatformModels
{
    public class PlatformDetail
    {
        public PlatformType PlatformType { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserID { get; set; }
        public User Users { get; set; }

        [ForeignKey(nameof(Games))]
        public int GameID { get; set; }
        public virtual Game Games { get; set; }
    }
}
