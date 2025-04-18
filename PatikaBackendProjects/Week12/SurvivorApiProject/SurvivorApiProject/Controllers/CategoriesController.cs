using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorApiProject.Context;
using SurvivorApiProject.Entities;
using SurvivorApiProject.Models.Category;
using SurvivorApiProject.Models.Competitor;

namespace SurvivorApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CategoriesController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _context.Categories
                .Where(x => !x.IsDeleted)
                .Select(x => new CategoryListResponse
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _context.Categories
                .Include(c => c.Competitors)
                .FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (category == null)
                return NotFound();

            var result = new CategoryDetailResponse
            {
                Id = category.Id,
                Name = category.Name,
                CreatedDate = category.CreatedDate,
                ModifiedDate = category.ModifiedDate,
                Competitors = category.Competitors
                    .Where(c => !c.IsDeleted)
                    .Select(c => new CompetitorListResponse
                    {
                        Id = c.Id,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        CategoryId = category.Id
                    }).ToList()
            };

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateRequest request)
        {
            var entity = new CategoryEntity
            {
                Name = request.Name,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            _context.Categories.Add(entity);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, null);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryUpdateRequest request)
        {
            var category = _context.Categories.Find(id);

            if (category == null || category.IsDeleted)
                return NotFound();

            category.Name = request.Name;
            category.ModifiedDate = DateTime.Now;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null || category.IsDeleted)
                return NotFound();

            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return Ok();
        }
    }
}
