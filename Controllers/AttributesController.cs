using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sqstr.Models;
using sqstr.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
      var priceResponse = await NomicsHelper.NomicsCall();
      var estimateResponse = await CarbonInterfaceHelper.CarbonInterfaceCall(request);

      string priceResult = priceResponse.Content.ReadAsStringAsync().Result;
      Console.WriteLine(priceResult);
      string estimateResult = estimateResponse.Content.ReadAsStringAsync().Result;

      JArray priceJson = JsonConvert.DeserializeObject<JArray>(priceResult);
      JObject root = JsonConvert.DeserializeObject<JObject>(priceJson[0].ToString());

      JObject estimateJson = JsonConvert.DeserializeObject<JObject>(estimateResult);

      root.Merge(estimateJson);
      Console.WriteLine(root);

      Root rootData = JsonConvert.DeserializeObject<Root>(root.ToString());
      // Data dataData = JsonConvert.DeserializeObject<Data>(root["data"].ToString());
      // Attributes attributesData = JsonConvert.DeserializeObject<Attributes>(estimateJson["data"]["attributes"].ToString());
      
      _db.Roots.Add(rootData);

      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = rootData.RootId }, rootData);
    }
  }
}