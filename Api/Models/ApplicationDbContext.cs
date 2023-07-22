using Microsoft.EntityFrameworkCore;

namespace Api.Models
{
    public class ApplicationDbContext: DbContext    
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(
                new Pet()
                {
                    Id = 1,
                    Name = "Sam",
                    Breed = "Gato",
                    Age = 2,
                    Color = "Amarillo",
                    Weight = 4,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new Pet()
                {
                    Id = 2,
                    Name = "Lucas",
                    Breed = "Gato",
                    Age = 1,
                    Color = "Blanco",
                    Weight = 2,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                }
                
            );
        }
    }
}
