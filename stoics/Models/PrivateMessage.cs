using System;

namespace stoics.Models
{
    public class PrivateMessage
    {
        public PrivateMessage(int authorId, int recipientId, ApplicationUser owner, string content)
        {
            AuthorId = authorId;
            RecipientId = recipientId;
            Owner = owner;
            Created = DateTime.Now;
            IsRead = false;
            IsTrashed = false;
        }

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
