using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, AnimalName = "Izzy", AnimalType = "Dog", AnimalBackground = "six year old white dog"},
          new Animal { AnimalId = 2, AnimalName = "Random", AnimalType = "Cat", AnimalBackground = " two year old calico cat"},
          new Animal { AnimalId = 3, AnimalName = "Gremlin", AnimalType = "Cat", AnimalBackground = "one year old long haired black and white cat"}
        );
    } 
  }
}