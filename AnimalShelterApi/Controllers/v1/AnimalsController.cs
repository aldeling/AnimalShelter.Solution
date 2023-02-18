using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class AnimalController: ControllerBase
  {
    private readonly AnimalShelterApi _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // Get api/
    [HttpGet]
    public async Task<List<Animal
  }
}