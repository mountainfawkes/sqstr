using Newtonsoft.Json;

namespace sqstr.Models
{
  public class Root
  {
    
    [JsonProperty("data")]
    public Data data { get; set; }
  }
}