using stoics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{  
    public class PostWithQuote : IPost
    {
        public PostWithQuote(ApplicationUser author, Quote quote)
        {
            Author = author;
            DateCreated = DateTime.Now;
            Quote = quote;
        }

        public int Id { get; set; }
        public ApplicationUser Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDraft { get; set; }
        public string Content { get; set; }
        public PrivacyLevel PostPrivacyLevel { get; set; }
        //to deal with flagged posts
        public bool IsDisplayed { get; set; }

        public Quote Quote { get; set; }
    }
}
