using System.ComponentModel.DataAnnotations.Schema;

namespace SurvivorApiProject.Entities
{
    public class CompetitorEntity : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public CategoryEntity ?Category { get; set; }
    }
}