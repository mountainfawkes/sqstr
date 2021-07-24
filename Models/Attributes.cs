using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace sqstr.Models
{
  public class Attributes
  {
    [JsonProperty("carbon_g")]
    public int Carbon_G { get; set; }
    
    [JsonProperty("carbon_lb")]
    public double Carbon_Lb { get; set; }
    
    [JsonProperty("carbon_kg")]
    public double Carbon_Kg { get; set; }
    
    [JsonProperty("carbon_mt")]
    public double Carbon_Mt { get; set; }
    
    [JsonProperty("country")]
    public string Country { get; set; }
    
    [JsonProperty("distance_unit")]
    public string Distance_Unit { get; set; }
    
    [JsonProperty("distance_value")]
    public double Distance_Value { get; set; }
    
    [JsonProperty("estimated_at")]
    public DateTime Estimated_At { get; set; }
    
    [JsonProperty("electricity_unit")]
    public string Electricity_Unit { get; set; }
    
    [JsonProperty("electricity_value")]
    public double Electricity_Value { get; set; }
    
    [JsonProperty("fuel_source_type")]
    public string Fuel_Source_Type { get; set; }
    
    [JsonProperty("fuel_source_unit")]
    public string Fuel_Source_Unit { get; set; }
    
    [JsonProperty("fuel_source_value")]
    public int Fuel_Source_Value { get; set; }
    
    [JsonProperty("legs")]
    public List<Leg> Legs { get; set; }
    
    [JsonProperty("passengers")]
    public int Passengers { get; set; }
    
    [JsonProperty("state")]
    public string State { get; set; }
    
    [JsonProperty("transport_method")]
    public string Transport_Method { get; set; }
    
    [JsonProperty("vehicle_make")]
    public string Vehicle_Make { get; set; }
    
    [JsonProperty("vehicle_model")]
    public string Vehicle_Model { get; set; }
    
    [JsonProperty("vehicle_year")]
    public int Vehicle_Year { get; set; }
    
    [JsonProperty("weight_value")]
    public string Weight_Value { get; set; }
    
    [JsonProperty("weight_unit")]
    public string Weight_Unit { get; set; }
  }
}