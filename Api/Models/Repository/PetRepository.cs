using Microsoft.EntityFrameworkCore;

namespace Api.Models.Repository
{
    public class PetRepository: IPetRepository
    {
        private readonly ApplicationDbContext _context;

        public PetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Pet> CreatePet(Pet pet)
        {
            _context.Add(pet);
            await _context.SaveChangesAsync();
            return pet;
        }

        public async Task DeletePet(Pet pet)
        {
            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();

        }

        public async Task<List<Pet>> GetListPets()
        {
           return await _context.Pets.ToListAsync();
        }

        public async Task<Pet> GetPetById(int id)
        { 
           return await _context.Pets.FindAsync(id);

        }

        public async Task UpdateTask(Pet pet)
        {
            var petItem = await _context.Pets.FirstOrDefaultAsync(x => x.Id == pet.Id);
            if (petItem != null)
            {
                petItem.Name = pet.Name;
                petItem.Breed = pet.Breed;
                petItem.Age = pet.Age;
                petItem.Color = pet.Color;
                petItem.Weight = pet.Weight;
                petItem.Updated = DateTime.Now;

                await _context.SaveChangesAsync();
            }
           
        }
    }
}
