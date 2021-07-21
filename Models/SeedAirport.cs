namespace sqstr.Models
{
  public class SeedAirport
  {
    public int SeedAirportId { get; set; }
    public string IATA { get; set; }
    public double Lat { get; set; }   // research the double type
    public double Lon { get; set; }   // research the double type
    public string Name { get; set; }
  }
}