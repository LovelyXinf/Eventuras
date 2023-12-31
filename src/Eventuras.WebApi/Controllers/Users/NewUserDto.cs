using System.ComponentModel.DataAnnotations;

namespace Eventuras.WebApi.Controllers.Users
{
    public class NewUserDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
