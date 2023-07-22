namespace Api.Models.Repository
{
    public interface IPetRepository
    {
        Task<List<Pet>> GetListPets();
        Task<Pet> GetPetById(int id);
        Task DeletePet(Pet pet);
        Task<Pet> CreatePet(Pet pet);
        Task UpdateTask(Pet pet);
    }
}
