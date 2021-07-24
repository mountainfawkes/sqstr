using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace sqstr.Models
{
  public class Root
  {
    public int RootId { get; set; }

    // Carbon Interface properties and data child relationship
    
    [JsonProperty("data")]
    public Data Data { get; set; }

    // Nomics properties

    [JsonProperty("currency")]
    public string Currency { get; set; }
    
    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("price_date")]
    public DateTime Price_Date { get; set; }

    [JsonProperty("price_timestamp")]
    public DateTime Price_Timestamp { get; set; }

    [JsonProperty("high")]
    public string High { get; set; }

    [JsonProperty("high_timestamp")]
    public DateTime High_Timestamp { get; set; }
  }
}