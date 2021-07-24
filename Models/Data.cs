using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sqstr.Models
{
  public class Data
  {
    [Key]
    public int DataId { get; set; }
    
    // Carbon Interface's unique query response estimate id

    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("type")]
    public string Type { get; set; }

    // Attributes parent relationship
    
    [JsonProperty("attributes")]
    public Attributes Attributes { get; set; }

    // Root child relationship

    public int RootId { get; set; }
  }
}