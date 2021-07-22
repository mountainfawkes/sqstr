namespace sqstr.Models
{
  public class Price
  {
    // Estimate properties

    public int PriceId { get; set; }
    public string Currency { get; set; }
    public double LatestPrice { get; set; }
    public string PriceDate { get; set; }

    // Estimates relationship

    public int EstimateId { get; set; }
    public Estimate Estimate { get; set; }
  }
}