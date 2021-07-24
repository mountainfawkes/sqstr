using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using sqstr.Models;

namespace sqstr.Helpers
{
  public class CarbonInterfaceHelper
  {
    // const string baseCarbonUrl = "https://www.carboninterface.com/";
    // const string carbonCallResource = "api/v1/estimates";
    static readonly string auth = "Bearer " + EnvironmentVariables.CarbonInterfaceBearerToken;

    public static async Task<Attributes> CarbonInterfaceCall()
    {
      var electricityRequest = new AttributesRequest { 
        Type = "electricity",
        Electricity_Unit = "mwh",
        Electricity_Value = 42,
        Country = "us",
        State = "or"
      };

      var url = "https://www.carboninterface.com/api/v1/estimates";
      var json = JsonConvert.SerializeObject(electricityRequest);
      var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
      HttpClient httpClient = new HttpClient();
      httpClient.DefaultRequestHeaders.Add("Authorization", auth);
      HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, url);
      var response = await httpClient.PostAsync(url, content);

      var result = response.Content.ReadAsStringAsync().Result;
      Attributes attributes = JsonConvert.DeserializeObject<Attributes>(result);

      return attributes;
    }
  }

  public class AttributesRequest
  {    
    [JsonProperty("country")]
    public string Country { get; set; }
    
    [JsonProperty("distance_unit")]
    public string Distance_Unit { get; set; }
    
    [JsonProperty("distance_value")]
    public double Distance_Value { get; set; }
    
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

    [JsonProperty("type")]
    public string Type { get; set; }
    
    [JsonProperty("vehicle_model_id")]
    public string Vehicle_Model_Id { get; set; }
    
    [JsonProperty("weight_value")]
    public string Weight_Value { get; set; }
    
    [JsonProperty("weight_unit")]
    public string Weight_Unit { get; set; }
  }

  public class ElectricityResponse
  {
    public string Id { get; set; }
    public string Type { get; set; }
  }
}

// RESTSHARP ATTEMPT
      // var body = JsonConvert.SerializeObject(data);
      // var client = new RestClient("https://www.carboninterface.com/");
      // var request = new RestRequest(Method.POST);
      // request.Resource = string.Format("api/v1/estimates");
      // request.AddParameter("Authorization", auth, ParameterType.HttpHeader);
      // request.AddParameter("application/json", body, ParameterType.RequestBody);
      // var response = await client.ExecuteTaskAsync(request);

      // if (response.ErrorException != null)
      // {
      //   const string message = "Error retrieving response. Check inner details.";
      //   var carbonInterfaceException = new Exception(message, response.ErrorException);
      //   throw carbonInterfaceException;
      // }