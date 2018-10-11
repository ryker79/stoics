using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stoics.Models
{
    public class Philosopher
    {
        public Philosopher(string name, DateTime birthday, string orderName = null, string biographyLink = null)
        {
            Name = name;
            Birthday = birthday;
            OrderName = orderName ?? name;
            BiographyLink = biographyLink ?? string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string OrderName { get; set; }
        public DateTime Birthday { get; set; }
        public string BiographyLink { get; set; }
    }
}
