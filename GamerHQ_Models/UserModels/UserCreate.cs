using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Models.UserModels
{
    public class UserCreate
    {
        public string Name { get; set; }
        [Required]
        public string GamerTag { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
