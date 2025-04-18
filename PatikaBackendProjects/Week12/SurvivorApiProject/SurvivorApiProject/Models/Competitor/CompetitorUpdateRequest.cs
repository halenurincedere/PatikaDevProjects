namespace SurvivorApiProject.Models.Competitor
{
    public class CompetitorUpdateRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CategoryId { get; set; }
    }
}
