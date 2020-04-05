using System.Collections.Generic;

namespace Fisher.Bookstore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Book> Books { get; set; }
        public List<BookAuthor> BookAuthor { get; set; }
    }
}