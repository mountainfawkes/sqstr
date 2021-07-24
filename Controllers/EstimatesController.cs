using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sqstr.Models;

namespace sqstr.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EstimatesController : ControllerBase
  {
    private readonly SqstrContext _db;

    public EstimatesController(SqstrContext db)
    {
      _db = db;
    }

    // GET api/estimates
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Estimate>>> Get()
    {
      return await _db.Estimates.ToListAsync();
    }

    // POST api/estimates
    [HttpPost]
    public async Task<ActionResult<Estimate>> Post(Estimate estimate)
    {
      _db.Estimates.Add(estimate);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = estimate.EstimateId }, estimate);
    }
  }
}