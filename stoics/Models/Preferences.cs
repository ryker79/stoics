using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class Preferences
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public PrivacyLevel PrivacyLevel { get; set; }
    }
}
