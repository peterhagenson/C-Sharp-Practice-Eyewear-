using EyeGlasses.Models;
using EyeGlasses.Services;
using Microsoft.AspNetCore.Mvs;

namespace EyeGlasses.Controllers;

[ApiController]
[Route("[controller]")]
public class GlassesController : ControllerBase
{
    public GlassesController()
    {

    }

//GET all
[HttpGet]
public ActionResult<List<Glasses>> GetAll() =>
    GlassesService.GetAll();

//GEt one action
[HttpGet("{id}")]
public ActionResult<Glasses> Get (int id)
{
    var glasses = GlassesService.Get(id);

    if(glasses == null)
        return NotFound();

    return glasses;
}
}