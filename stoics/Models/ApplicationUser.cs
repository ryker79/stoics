using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace stoics.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime dateTime { get; set; }
        public ICollection<string> FollowedUsers { get; set; }
        public ICollection<string> BlockedUsers { get; set; }
        public string Pic { get; set; }
        public Profile Profile { get; set; }
        public DateTime SuspendedUntil { get; set; }
        public PrivacyLevel AccountPrivacyLevel { get; set; }
    }
}
