using Newtonsoft.Json;

namespace sqstr.Models
{
  public class Leg
  {
    public int Id { get; set; }
    
    [JsonProperty("departure_airport")]
    public string Departure_Airport { get; set; }
    
    [JsonProperty("destination_airport")]
    public string Destination_Airport { get; set; }

    // Attributes relationship
    public int AttributesId { get; set; }
    public Attributes Attributes { get; set; }
  }
}