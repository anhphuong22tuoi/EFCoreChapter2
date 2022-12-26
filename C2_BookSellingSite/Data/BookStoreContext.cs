using Microsoft.EntityFrameworkCore;
using Models;

namespace C2_BookSellingSite.Data
{
  public class BookStoreContext : DbContext
  {
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<PriceOffer> PriceOffers { get; set; }

    public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<BookAuthor>()
          .HasKey(x => new { x.BookId, x.AuthorId });
    }
  }
}
