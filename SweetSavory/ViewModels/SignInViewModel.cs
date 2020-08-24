using System.ComponentModel.DataAnnotations;

namespace SweetSavory.ViewModels
{
    public class SignInViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}