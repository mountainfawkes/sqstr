using RestSharp;
using Newtonsoft.Json;
using System;
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

    public static async Task<Electricity> CarbonInterfaceCall()
    {
      var electricityRequest = new ElectricityRequest { 
        Type = "electricity",
        Electricity_Unit = "mwh",
        Electricity_Value = 42,
        Country = "us",
        State = "or"
      };

      Console.WriteLine(electricityRequest);
      
      var url = "https://www.carboninterface.com/api/v1/estimates";
      var json = JsonConvert.SerializeObject(electricityRequest);
      var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
      HttpClient httpClient = new HttpClient();
      HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, url);
      message.Headers.Add("Authorization", auth);
      var response = await httpClient.PostAsync(url, content);
      
      var result = response.Content.ReadAsStringAsync().Result;
      Electricity electricity = JsonConvert.DeserializeObject<Electricity>(result);
      
      

      return electricity;
    }
  }

  public class ElectricityRequest
  {
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("electricity_unit")]
    public string Electricity_Unit { get; set; }
    
    [JsonProperty("electricity_value")]
    public float Electricity_Value { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }
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