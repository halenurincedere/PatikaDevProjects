using Microsoft.AspNetCore.Mvc;
using CrazyMusiciansAPI.Models;

namespace CrazyMusiciansAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static readonly List<Musician> musicians = new List<Musician>()
        {
            new Musician(){ Id = 1, FullName = "Ahmet Çalgı", Profession = "Famous Instrument Player", FunnyProperty = "Always plays the wrong note, but it's so much fun"},
            new Musician(){ Id = 2, FullName = "Zeynep Melodi", Profession = "Popular Melody Writer", FunnyProperty = "Her songs are misunderstood but very popular"},
            new Musician(){ Id = 3, FullName = "Cemil Akor", Profession = "Crazy Accordist", FunnyProperty = "Changes chords often, but surprisingly talented"},
            new Musician(){ Id = 4, FullName = "Fatma Nota", Profession = "Surprise Note Generator", FunnyProperty = "Constantly prepares surprises while producing notes"},
            new Musician(){ Id = 5, FullName = "Hasan Ritim", Profession = "Rhythm Monster", FunnyProperty = "He makes each beat in his own way, it never fits, but it's funny"},
            new Musician(){ Id = 6, FullName = "Elif Armoni", Profession = "Master of Harmony", FunnyProperty = "She sometimes plays harmonies wrong, but he is very creative"},
            new Musician(){ Id = 7, FullName = "Ali Perde", Profession = "Fret Applicator", FunnyProperty = "Plays every fret differently, always surprising"},
            new Musician(){ Id = 8, FullName = "Ayşe Rezonans", Profession = "Resonance Expert", FunnyProperty = "Specializes in resonance, but sometimes makes a lot of noise"},
            new Musician(){ Id = 9, FullName = "Murat Ton", Profession = "Intonation Enthusiast", FunnyProperty = "The differences in intonation are sometimes funny, but quite interesting"},
            new Musician(){ Id = 10, FullName = "Selin Akor", Profession = "Chord Wizard", FunnyProperty = "When she change chords, sometimes it creates a magical atmosphere"}
        };

        // GET: api/musicians
        [HttpGet]
        public ActionResult<List<Musician>> ReadAll()
        {
            return Ok(musicians);
        }

        // GET: api/musicians/{id}
        [HttpGet("{id}")]
        public ActionResult<Musician> ReadOne(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if (musician == null)
                return NotFound();

            return Ok(musician);
        }

        // GET: api/musicians/search?fullName={name}
        [HttpGet("search")]
        public ActionResult<List<Musician>> Search([FromQuery] string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return BadRequest("Search query cannot be empty.");

            var result = musicians.Where(m => m.FullName.Contains(fullName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
                return NotFound("No musicians found matching the search criteria.");

            return Ok(result);
        }

        // POST: api/musicians
        [HttpPost]
        public ActionResult<Musician> Create([FromBody] Musician musician)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            musician.Id = musicians.Max(m => m.Id) + 1;

            musicians.Add(musician);

            return CreatedAtAction(nameof(Create), new { id = musician.Id }, musician);
        }

        // PUT: api/musician/{id}
        [HttpPut("{id:int:min(1)}")]
        public IActionResult Update(int id, [FromBody] Musician updatedMusician)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if (musician == null)
                return NotFound();

            musician.FullName = updatedMusician.FullName;
            musician.Profession = updatedMusician.Profession;
            musician.FunnyProperty = updatedMusician.FunnyProperty;

            return NoContent();
        }

        // PATCH: api/musicians/{id}
        [HttpPatch("{id:int:min(1)}")]
        public IActionResult Patch(int id, [FromBody] string fullName)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if (musician == null)
                return NotFound();

            if (string.IsNullOrWhiteSpace(fullName))
                return BadRequest("Full Name cannot be empty or null.");

            musician.FullName = fullName;

            return NoContent();
        }

        // DELETE: api/musicians/{id}
        [HttpDelete("{id:int:min(1)}")]
        public IActionResult Delete(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);

            if (musician == null)
                return NotFound();

            musicians.Remove(musician);

            return NoContent();
        }


    }
}