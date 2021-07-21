namespace sqstr.Models
{
  public class Vehicle
  {
    public int VehicleId { get; set; }
    public float CarbonG { get; set; }
    public float CarbonLb { get; set; }
    public float CarbonKg { get; set; }
    public float CarbonMt { get; set; }
    public string DistanceUnit { get; set; }
    public float DistanceValue { get; set; }
    public string EstimatedAt { get; set; }
    public string VehicleMake { get; set; }
    public string VehicleModel { get; set; }
    public string VehicleModelId { get; set; }
    public int VehicleYear { get; set; }
  }
}