using Domain.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class RegisterRequestModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        public UserType UserType { get; set; }
    }
}
