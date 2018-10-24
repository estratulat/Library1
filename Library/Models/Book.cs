using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<BookAuthor> Author { get; set; }
        public ICollection<Publisher> Publisher { get; set; }
        public ICollection<Genre> Genre { get; set; }
    }
}
