using System.Collections.Generic;

namespace Fisher.Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public List<Author> Authors { get; set; }
        public List<BookAuthor> BookAuthor { get; set; }
    }
}