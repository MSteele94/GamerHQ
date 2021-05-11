using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Models.UserModels
{
    public class UserEdit
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string GamerTag { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
