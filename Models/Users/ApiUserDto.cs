//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace HotelListing.API.Models.Users
{
    public class ApiUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage ="Your Password is limited to {2} to {1} character",MinimumLength = 6)]
        public string Password { get; set; }
    }
}
