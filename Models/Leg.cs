using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace sqstr.Models
{
  public class Leg
  {
    [Key]
    public int LegsId { get; set; }
    
    [JsonProperty("departure_airport")]
    public string Departure_Airport { get; set; }
    
    [JsonProperty("destination_airport")]
    public string Destination_Airport { get; set; }
  }
}