using stoics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Interfaces
{
    public interface IPost
    {
        int Id { get; set; }
        ApplicationUser Author { get; }
        DateTime DateCreated { get; }
        DateTime DateUpdated { get; set; }
        bool IsPublic { get; set; }
        bool IsDraft { get; set; }
        string Content { get; set; }
        PrivacyLevel PostPrivacyLevel { get; set; }
        //to deal with flagged posts
        bool IsDisplayed { get; set; }
    }
}
