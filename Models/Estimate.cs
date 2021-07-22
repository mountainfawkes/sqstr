using System.Collections.Generic;

namespace sqstr.Models
{
  public class Estimate
  {
    public Estimate()
    {
      this.Electricities = new HashSet<Electricity>();
      this.Flights = new HashSet<Flight>();
      this.Fuels = new HashSet<Fuel>();
      this.Prices = new HashSet<Price>();
      this.Shippings = new HashSet<Shipping>();
      this.Vehicles = new HashSet<Vehicle>();
    }

    // Estimate properties
    public int EstimateId { get; set; }
    public string InterfaceEstimateId { get; set; }

    // One-to-many relationships with estimate types
    
    public ICollection<Electricity> Electricities { get; set; }
    public ICollection<Flight> Flights { get; set; }
    public ICollection<Fuel> Fuels { get; set; }
    public ICollection<Price> Prices { get; set; }
    public ICollection<Shipping> Shippings { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
  }
}