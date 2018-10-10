﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class PrivateMessage
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int RecipientId { get; set; }
        public ApplicationUser Owner { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public bool IsTrashed { get; set; }
    }
}
