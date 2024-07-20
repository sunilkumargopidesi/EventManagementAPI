using System.ComponentModel.DataAnnotations;

namespace EventManagementAPI.DTOs_folder
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
