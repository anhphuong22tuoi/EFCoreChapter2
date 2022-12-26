namespace Models
{
  public class Review
  {
    public int Id { get; set; }
    public string VoterName { get; set; }
    public int NumStars { get; set; }
    public string Comment { get; set; }
    public int BookId { get; set; }

    public Book Book { get; set; }
  }
}
