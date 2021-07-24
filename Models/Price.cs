namespace sqstr.Models
{
  public class Price
  {
    public int PriceId { get; set; }
    public string Currency { get; set; }
    public double LatestPrice { get; set; }
    public string PriceDate { get; set; }
  }
}