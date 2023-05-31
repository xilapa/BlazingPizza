using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class SpecialsController : ControllerBase
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PizzaSpecial>>> GetSpecials()
    {
        var specials = await _db.Specials.ToArrayAsync();
        return Ok(specials.OrderByDescending(s => s.BasePrice));
    }
}