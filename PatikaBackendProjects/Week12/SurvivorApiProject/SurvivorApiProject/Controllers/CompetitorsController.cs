using Microsoft.AspNetCore.Mvc;
using SurvivorApiProject.Context;
using SurvivorApiProject.Entities;
using SurvivorApiProject.Models.Competitor;

namespace SurvivorApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorsController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var competitors = _context.Competitors
                .Where(x => !x.IsDeleted)
                .Select(x => new CompetitorListResponse
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    CategoryId = x.CategoryId
                }).ToList();

            return Ok(competitors);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var competitor = _context.Competitors.Find(id);

            if (competitor == null || competitor.IsDeleted)
                return NotFound();

            var result = new CompetitorDetailResponse
            {
                Id = competitor.Id,
                FirstName = competitor.FirstName,
                LastName = competitor.LastName,
                CategoryId = competitor.CategoryId,
                CreatedDate = competitor.CreatedDate,
                ModifiedDate = competitor.ModifiedDate
            };

            return Ok(result);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult GetByCategory(int categoryId)
        {
            var competitors = _context.Competitors
                .Where(x => !x.IsDeleted && x.CategoryId == categoryId)
                .Select(x => new CompetitorListResponse
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    CategoryId = x.CategoryId
                }).ToList();

            return Ok(competitors);
        }

        [HttpPost]
        public IActionResult Create(CompetitorCreateRequest request)
        {
            var entity = new CompetitorEntity
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                CategoryId = request.CategoryId,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            _context.Competitors.Add(entity);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, null);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CompetitorUpdateRequest request)
        {
            var competitor = _context.Competitors.Find(id);

            if (competitor == null || competitor.IsDeleted)
                return NotFound();

            competitor.FirstName = request.FirstName;
            competitor.LastName = request.LastName;
            competitor.CategoryId = request.CategoryId;
            competitor.ModifiedDate = DateTime.Now;

            _context.Competitors.Update(competitor);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var competitor = _context.Competitors.Find(id);

            if (competitor == null || competitor.IsDeleted)
                return NotFound();

            competitor.IsDeleted = true;
            competitor.ModifiedDate = DateTime.Now;

            _context.Competitors.Update(competitor);
            _context.SaveChanges();

            return Ok();
        }
    }
}
