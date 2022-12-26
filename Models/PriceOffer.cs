namespace Models
{
  public class PriceOffer
  {
    public int Id { get; set; }
    public double NewPrice { get; set; }
    public string PromotionalText { get; set; }
    public int BookId { get; set; }

    public Book Book { get; set; }
  }
}
