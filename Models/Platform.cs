using System.ComponentModel.DataAnnotations;

namespace PLATFORMSERVICE.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Publsher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
