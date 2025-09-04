using System.ComponentModel.DataAnnotations;

namespace MVCCore.Shared.Models
{
    public class Bulldog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Breed is required.")]
        public string Breed { get; set; }

        public string? ImageUrl { get; set; }
    }
}