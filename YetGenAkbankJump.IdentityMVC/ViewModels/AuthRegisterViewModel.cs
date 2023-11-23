using System.ComponentModel.DataAnnotations;
using YetgenAkbankJump.Domain.Enums;

namespace YetGenAkbankJump.IdentityMVC.ViewModels
{
    public class AuthRegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(2)]
        public string UserName { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SurName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }
}
