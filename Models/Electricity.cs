using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace sqstr.Models
{
  public class Electricity
  {
    // Class constructor to parse json data
    // public Electricity(float carbonG, float carbonLb, float carbonKg, float carbonMt, string country, string electricityUnit, float electricityValue, string estimatedAt, string state)
    // {
    //   CarbonG = carbonG;
    //   CarbonLb = carbonLb;
    //   CarbonKg = carbonKg;
    //   CarbonMt = carbonMt;
    //   Country = country;
    //   ElectricityUnit = electricityUnit;
    //   ElectricityValue = electricityValue;
    //   EstimatedAt = estimatedAt;
    //   State = state;
    // }

    // Estimate properties

    public int ElectricityId { get; set; }

    [JsonProperty("carbon_g")]
    public float CarbonG { get; set; }

    [JsonProperty("carbon_lb")]
    public float CarbonLb { get; set; }

    [JsonProperty("carbon_kg")]
    public float CarbonKg { get; set; }

    [JsonProperty("carbon_mt")]
    public float CarbonMt { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("electricity_unit")]
    public string ElectricityUnit { get; set; }

    [JsonProperty("electricity_value")]
    public float ElectricityValue { get; set; }

    [JsonProperty("estimated_at")]
    public string EstimatedAt { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    // Estimates relationship

    public int EstimateId { get; set; }
    public Estimate Estimate { get; set; }
  }
}