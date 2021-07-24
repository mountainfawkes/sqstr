using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace sqstr.Models
{
  public class Estimate
  {
    public Estimate()
    {
      Electricities = new HashSet<Electricity>();
      Flights = new HashSet<Flight>();
      Fuels = new HashSet<Fuel>();
      Prices = new HashSet<Price>();
      Shippings = new HashSet<Shipping>();
      Vehicles = new HashSet<Vehicle>();
    }

    // // Overload constructor to parse json response
    // public Estimate(string interfaceEstimateId)
    // {
    //   InterfaceEstimateId = interfaceEstimateId;
    // }

    // Estimate properties
    [Key]
    public int EstimateId { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    // One-to-many relationships with estimate types
    
    public ICollection<Electricity> Electricities { get; set; }
    public ICollection<Flight> Flights { get; set; }
    public ICollection<Fuel> Fuels { get; set; }
    public ICollection<Price> Prices { get; set; }
    public ICollection<Shipping> Shippings { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
  }
}