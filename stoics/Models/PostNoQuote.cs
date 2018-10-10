using stoics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class PostNoQuote : IPost
    {
        public PostNoQuote(ApplicationUser author)
        {
            Author = author;
            DateCreated = DateTime.Now;
        }

        public int Id { get; set; }
        public ApplicationUser Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDraft { get; set; }
        public string Content { get; set; }
        public PrivacyLevel privacyLevel { get; set; }
        //to deal with flagged posts
        public bool IsDisplayed { get; set; }
    }
}
