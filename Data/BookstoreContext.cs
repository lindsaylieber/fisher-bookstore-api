using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options
        )
            : base(options)
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder) =>
        //base.OnModelCreating(builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BookAuthor>()
            .HasKey(ba => new { ba.BookId, ba.AuthorId });

            builder.Entity<BookAuthor>()
            .HasOne(ba => ba.Book)
            .WithMany(b => b.BookAuthor)
            .HasForeignKey(ba => ba.BookId);

            builder.Entity<BookAuthor>()
            .HasOne(ba => ba.Author)
            .WithMany(a => a.BookAuthor)
            .HasForeignKey(ba => ba.AuthorId);
        }
    }
}