using System.ComponentModel.DataAnnotations;

namespace sqstr.Models
{
  public class SeedFuel
  {
    public int SeedFuelId { get; set; }
    public string Code { get; set; }
    public string FuelSourceUnit { get; set; }
    public string Name { get; set; }
  }
}