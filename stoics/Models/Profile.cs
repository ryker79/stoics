using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class Profile
    {
        public Profile(ApplicationUser user){}

        public int Id { get; }
        public ApplicationUser User { get; }
        public string About { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Reddit { get; set; }
    }
}
