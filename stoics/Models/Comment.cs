using stoics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public ApplicationUser Author { get; set; }
        public IPost Post { get; set; }
        public string Content { get; set; }
        public DateTime TimeCreated { get; set; }
        //to deal with flagged posts
        public bool IsDisplayed { get; set; }
    }
}
