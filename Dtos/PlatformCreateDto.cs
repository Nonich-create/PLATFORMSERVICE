using System.ComponentModel.DataAnnotations;

namespace PLATFORMSERVICE.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Publsher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
