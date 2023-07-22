using Api.Models;
using Api.Models.Dto;
using Api.Models.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
      

        private readonly IMapper _mapper;
        private readonly IPetRepository _petRepository;

        public PetController(IMapper mapper, IPetRepository petRepository)
        {
            _mapper = mapper;
            _petRepository = petRepository; 
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                //Thread.Sleep(1000);
                var listPets = await _petRepository.GetListPets();

                var listPetsDto = _mapper.Map<IEnumerable<PetDto>>(listPets);

                return Ok(listPetsDto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            try
            {
                
                var pet = await _petRepository.GetPetById(id);

                if(pet == null)
                {
                    return NotFound();
                }

                var petDto = _mapper.Map<PetDto>(pet);

                return Ok(petDto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id) 
        {
            try
            {
                var pet = await _petRepository.GetPetById(id);
                
                if(pet == null)
                {
                    return NotFound();
                }

                await _petRepository.DeletePet(pet);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public  async Task<IActionResult> Post(PetDto petDto)
        {
            try
            {
                var pet = _mapper.Map<Pet>(petDto);

                pet.Created = DateTime.Now;
                pet.Updated = DateTime.Now;

                pet = await _petRepository.CreatePet(pet);

                var modelo = _mapper.Map<PetDto>(pet);

                return CreatedAtAction("Get", new {id = modelo.Id}, modelo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PetDto petDto)
        {
            try
            {
                var pet = _mapper.Map<Pet>(petDto);

                if (id != pet.Id)
                {
                    return BadRequest();
                }

                var petItem = await _petRepository.GetPetById(id);

                if(petItem == null)
                {
                    return NotFound();
                }

                await _petRepository.UpdateTask(pet);
               
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
