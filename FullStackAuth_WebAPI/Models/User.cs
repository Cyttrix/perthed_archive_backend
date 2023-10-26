using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FullStackAuth_WebAPI.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
