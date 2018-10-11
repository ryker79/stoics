using stoics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class PostResponse : IPost
    {
        public PostResponse(ApplicationUser author, IPost originalPost)
        {
            Author = author;
            DateCreated = DateTime.Now;
            OriginalPost = originalPost;
        }
        public int Id { get; set; }
        public ApplicationUser Author { get; }
        public DateTime DateCreated { get; }
        public DateTime DateUpdated { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDraft { get; set; }
        public string Content { get; set; }
        public PrivacyLevel PostPrivacyLevel { get; set; }
        //to deal with flagged posts
        public bool IsDisplayed { get; set; }

        public IPost OriginalPost { get; set; }
    }
}
