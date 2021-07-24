using Newtonsoft.Json;

namespace sqstr.Models
{
  public class Leg
  {
    
    [JsonProperty("departure_airport")]
    public string Departure_Airport { get; set; }
    
    [JsonProperty("destination_airport")]
    public string Destination_Airport { get; set; }
  }
}