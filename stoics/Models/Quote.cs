namespace stoics.Models
{
    public class Quote
    {
        public Quote(string content, Philosopher philosopher
            )
        {
            Content = content;
            Philosopher = philosopher;
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public Philosopher Philosopher { get; set; }
    }
}