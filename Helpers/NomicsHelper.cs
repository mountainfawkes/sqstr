using Newtonsoft.Json;
using sqstr.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sqstr.Helpers
{
  public class NomicsHelper
  {
    static readonly string url = $"https://api.nomics.com/v1/currencies/ticker?key={EnvironmentVariables.NomicsApiKey}&ids=UPCO2";

    public static async Task<HttpResponseMessage> NomicsCall()
    {
      HttpClient client = new HttpClient();
      var response = await client.GetAsync(url);

      return response;
    }
  }
}