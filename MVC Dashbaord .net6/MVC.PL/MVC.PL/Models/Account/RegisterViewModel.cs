using System.ComponentModel.DataAnnotations;

namespace MVC.PL.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [MinLength(5, ErrorMessage = "MinLength is 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public bool IsAgree { get; set; }

    }
}
