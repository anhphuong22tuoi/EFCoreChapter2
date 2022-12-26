namespace Models
{
  public class Book
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PublishedOn { get; set; }
    public string Publisher { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public bool SoftDeleted { get; set; }

    public ICollection<BookAuthor> AuthorsLink { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public PriceOffer PriceOffer { get; set; }
  }
}
