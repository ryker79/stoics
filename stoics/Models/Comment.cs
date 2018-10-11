using stoics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class Comment
    {
        public Comment(ApplicationUser author, IPost post, string Content)
        {
            Author = author;
            Post = post;
            TimeCreated = DateTime.Now;
            IsDisplayed = true;
        }

        public int Id { get; set; }
        public ApplicationUser Author { get; }
        public IPost Post { get; }
        public string Content { get; }
        public DateTime TimeCreated { get; }
        public int flagCount { get; set; }
        //to deal with flagged posts
        public bool IsDisplayed { get; set; }
    }
}
