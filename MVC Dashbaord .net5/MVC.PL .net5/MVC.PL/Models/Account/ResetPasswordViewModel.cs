using System.ComponentModel.DataAnnotations;

namespace MVC.PL.Models.Account
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Password Is Required")]
        [MinLength(5, ErrorMessage = "MinLength is 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string Token { get; set; }

    }
}
