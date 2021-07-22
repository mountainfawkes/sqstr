using System.Collections.Generic;

namespace sqstr.Models
{
  public class Flight
  {
    public Flight()
    {
      this.Legs = new HashSet<Leg>();
    }

    // Estimate properties

    public int FlightId { get; set; }
    public float CarbonG { get; set; }
    public float CarbonLb { get; set; }
    public float CarbonKg { get; set; }
    public float CarbonMt { get; set; }
    public string DistanceUnit { get; set; }
    public float DistanceValue { get; set; }
    public string EstimatedAt { get; set; }
    public int Passengers { get; set; }

    // One-to-many relationship with flight legs
    public ICollection<Leg> Legs { get; set; }

    // Estimates relationship

    public int EstimateId { get; set; }
    public Estimate Estimate { get; set; }
  }
}