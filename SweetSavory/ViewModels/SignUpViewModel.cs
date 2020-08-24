using System.ComponentModel.DataAnnotations;

namespace SweetSavory.ViewModels
{
  public class SignUpViewModel
  {
    [Required()]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required()]
    [StringLength(50, ErrorMessage= "The {0} must be a least {2} characters long.", MinimumLength = 6)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage="Valid passwords inclue a lower case character, uppercase character, and a number.")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
  }
}