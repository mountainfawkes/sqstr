using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sqstr.Models;
using sqstr.Helpers;

namespace sqstr.Controllers
{
  [Route("api/[Controller]")]
  [ApiController]
  public class AttributesController : ControllerBase
  {
    private readonly SqstrContext _db;

    public AttributesController(SqstrContext db)
    {
      _db = db;
    }

    // GET api/attributes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Attributes>>> Get()
    {
      return await _db.Attributes.ToListAsync();
    }

    // POST api/Attributes
    [HttpPost]
    [EnableCors("defaultPolicy")]
    public async Task<ActionResult<Attributes>> Post(AttributesRequest request)
    {
      string auth = "Bearer " + EnvironmentVariables.CarbonInterfaceBearerToken;

      var url = "https://www.carboninterface.com/api/v1/estimates";
      var json = JsonConvert.SerializeObject(request);
      var content = new StringContent(json, Encoding.UTF8, "application/json");
      HttpClient httpClient = new HttpClient();
      httpClient.DefaultRequestHeaders.Add("Authorization", auth);
      var response = await httpClient.PostAsync(url, content);

      string result = response.Content.ReadAsStringAsync().Result;
      Console.WriteLine(result);

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Console.WriteLine(jsonResponse);

      Attributes attributes = JsonConvert.DeserializeObject<Attributes>(jsonResponse["data"]["attributes"].ToString());
      Console.WriteLine(attributes);

      // string body = JsonConvert.SerializeObject(data);
      // var apiCallTask = CarbonInterfaceHelper.CarbonInterfaceCall();
      // var result = apiCallTask.Result;

      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // Electricity estimate = JsonConvert.DeserializeObject<Electricity>(jsonResponse["data"].ToString());
      
      _db.Attributes.Add(attributes);

      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = attributes.Id }, attributes);
    }

    // POST overload for Electricity instance
    // [HttpPost]
    // public async Task<ActionResult<Electricity>> Post(Electricity electricity)
    // {
    //   _db.Electricities.Add(electricity);
    //   await _db.SaveChangesAsync();

    //   return CreatedAtAction("Post", new { id = electricity.ElectricityId }, electricity);
    // }
  }
}