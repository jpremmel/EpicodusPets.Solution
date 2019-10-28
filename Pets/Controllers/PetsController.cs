using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EpicodusPets.Models;
using Microsoft.EntityFrameworkCore;

namespace EpicodusPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private PetsContext _db;

        public PetsController(PetsContext db)
        {
            _db = db;
        }

        // POST api/pets
        [HttpPost]
        public void Post([FromBody] Pet pet)
        {
            _db.Pets.Add(pet);
            _db.SaveChanges();
        }

        // GET api/pets/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            return _db.Pets.FirstOrDefault(entry => entry.PetId == id);
        }

        // PUT api/pets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pet pet)
        {
            pet.PetId = id;
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // PATCH api/pets/{id}
        [HttpPatch("{id}")]
        public void UpdateAge(int id, [FromBody] int age)
        {
            Pet pet = _db.Pets.FirstOrDefault(p => p.PetId == id);
            pet.Age = age;
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/pets/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var petToDelete = _db.Pets.FirstOrDefault(entry => entry.PetId == id);
            _db.Pets.Remove(petToDelete);
            _db.SaveChanges();
        }

        // GET api/pets
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get(string species, string gender, string name, string breed, string description, string favoriteThings, string leastFavoriteThings, string owner)
        {
            var query = _db.Pets.AsQueryable();

            if(species != null)
            {
                query = query.Where(entry => entry.Species.ToLower().Contains(species.ToLower()));
            }
            if(gender != null)
            {
                query = query.Where(entry => entry.Gender.ToLower().Contains(gender.ToLower()));
            }
            if(name != null)
            {
                query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
            }
            if(breed != null)
            {
                query = query.Where(entry => entry.Breed.ToLower().Contains(breed.ToLower()));
            }
            if(description != null)
            {
                query = query.Where(entry => entry.Description.ToLower().Contains(description.ToLower()));
            }
            if(favoriteThings != null)
            {
                query = query.Where(entry => entry.FavoriteThings.ToLower().Contains(favoriteThings.ToLower()));
            }
            if(leastFavoriteThings != null)
            {
                query = query.Where(entry => entry.LeastFavoriteThings.ToLower().Contains(leastFavoriteThings.ToLower()));
            }
            if(owner != null)
            {
                query = query.Where(entry => entry.Owner.ToLower().Contains(owner.ToLower()));
            }

            return query.ToList();
        }
    }
}