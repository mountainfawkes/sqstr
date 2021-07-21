namespace sqstr.Models
{
  public class Flight
  {
    public int FlightId { get; set; }
    public float CarbonG { get; set; }
    public float CarbonLb { get; set; }
    public float CarbonKg { get; set; }
    public float CarbonMt { get; set; }
    public string DistanceUnit { get; set; }
    public float DistanceValue { get; set; }
    public string EstimatedAt { get; set; }
    public int LegId { get; set; }
    public int Passengers { get; set; }
  }
}