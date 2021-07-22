namespace sqstr.Models
{
  public class Leg
  {
    // Leg properties

    public int LegId { get; set; }
    public string DepartureAirport { get; set; }
    public string DestinationAirport { get; set; }

    // Flights relationship

    public int FlightId { get; set; }
    public Flight Flight { get; set; }
  }
}