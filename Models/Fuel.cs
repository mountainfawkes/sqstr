namespace sqstr.Models
{
  public class Fuel
  {
    public int FuelId { get; set; }
    public float CarbonG { get; set; }
    public float CarbonLb { get; set; }
    public float CarbonKg { get; set; }
    public float CarbonMt { get; set; }
    public string EstimatedAt { get; set; }
    public string FuelSourceType { get; set; }
    public string FuelSourceUnit { get; set; }
    public float FuelSourceValue { get; set; }
  }
}