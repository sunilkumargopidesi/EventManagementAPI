using System.ComponentModel.DataAnnotations;

namespace EventManagementAPI.DTOs_folder
{
    public class CreateEventDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Organizer { get; set; }
    }
}
