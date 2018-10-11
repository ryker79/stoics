using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class Preferences
    {
        public Preferences(ApplicationUser applicationUser)
        {
            User = applicationUser;
        }

        public int Id { get; set; }
        public ApplicationUser User { get; set; }
    }
}
