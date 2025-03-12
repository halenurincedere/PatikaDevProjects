using System.ComponentModel.DataAnnotations;

namespace CrazyMusiciansAPI.Models
{
    public class Musician
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required.")]
        [StringLength(100, ErrorMessage = "Full Name cannot exceed 100 characters.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Profession is required.")]
        [StringLength(50, ErrorMessage = "Profession cannot exceed 50 characters.")]
        public string? Profession { get; set; }

        [StringLength(200, ErrorMessage = "Funny Property cannot exceed 200 characters.")]
        public string? FunnyProperty { get; set; }
    }
}