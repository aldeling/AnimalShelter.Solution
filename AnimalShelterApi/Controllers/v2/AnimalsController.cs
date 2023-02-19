using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers.v2
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("2.0")]
  public class AnimalsController: ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // Get api/animals
    [HttpGet]
    public async Task<List<Animal>> Get(string AnimalName, string AnimalType, string AnimalBackground)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if(AnimalName != null)
      {
        query = query.Where(entry => entry.AnimalName == AnimalName);
      }

      if(AnimalType != null)
      {
        query = query.Where(entry => entry.AnimalType == AnimalType);
      }

      if(AnimalBackground != null)
      {
        query = query.Where(entry => entry.AnimalBackground == AnimalBackground);
      }
      return await query.ToListAsync();
    }

    //Get api/animals/#
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }
      return animal;
    }

    //Post api/animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    //Put api/animals/#
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Animals.Update(animal);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private Boolean AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

    //Delete api/animals/#
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }
      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}