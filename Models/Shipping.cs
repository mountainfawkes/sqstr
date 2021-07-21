namespace sqstr.Models
{
  public class Shipping
  {
    public int ShippingId { get; set; }
    public float CarbonG { get; set; }
    public float CarbonLb { get; set; }
    public float CarbonKg { get; set; }
    public float CarbonMt { get; set; }
    public string DistanceUnit { get; set; }
    public float DistanceValue { get; set; }
    public string EstimatedAt { get; set; }
    public string WeightUnit { get; set; }
    public float WeightValue { get; set; }
  }
}