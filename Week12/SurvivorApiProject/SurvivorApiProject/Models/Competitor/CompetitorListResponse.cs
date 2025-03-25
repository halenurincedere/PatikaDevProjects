namespace SurvivorApiProject.Models.Competitor
{
    public class CompetitorListResponse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CategoryId { get; set; }
    }
}
