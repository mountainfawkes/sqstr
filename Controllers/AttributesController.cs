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
      var response = await CarbonInterfaceHelper.CarbonInterfaceCall(request);

      string result = response.Content.ReadAsStringAsync().Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);

      Attributes attributes = JsonConvert.DeserializeObject<Attributes>(jsonResponse["data"]["attributes"].ToString());
      
      _db.Attributes.Add(attributes);

      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = attributes.Id }, attributes);
    }
  }
}