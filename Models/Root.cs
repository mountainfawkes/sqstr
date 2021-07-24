using Newtonsoft.Json;

namespace sqstr.Models
{
  public class Root
  {
    public int Id { get; set; }
    
    [JsonProperty("data")]
    public Data data { get; set; }
  }
}