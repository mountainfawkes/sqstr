namespace sqstr.Models
{
  public class Electricity
  {
    // Estimate properties

    public int ElectricityId { get; set; }
    public float CarbonG { get; set; }
    public float CarbonLb { get; set; }
    public float CarbonKg { get; set; }
    public float CarbonMt { get; set; }
    public string Country { get; set; }
    public float DistanceUnit { get; set; }
    public float DistanceValue { get; set; }
    public string ElectricityUnit { get; set; }
    public string ElectricityValue { get; set; }
    public string EstimatedAt { get; set; }
    public string State { get; set; }

    // Estimates relationship

    public int EstimateId { get; set; }
    public Estimate Estimate { get; set; }
  }
}