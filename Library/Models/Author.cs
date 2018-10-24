using System.Collections.Generic;

namespace Library.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BookAuthor> Books { get; set; }
    }
}