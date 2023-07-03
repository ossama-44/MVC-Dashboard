using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.DAL.Entites;
using MVC.PL.Helper;
using MVC.PL.Models.Account;
using System.Threading.Tasks;

namespace MVC.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        #region Sign Up

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email.Split('@')[0],
                    IsAgree = registerViewModel.IsAgree
                };

                var result = await this.userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                    return RedirectToAction("SignIn");

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(registerViewModel);
        }
        #endregion

        #region Login
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await this.userManager.FindByEmailAsync(loginViewModel.Email);
                if (user is not null)
                {
                    var password = await this.userManager.CheckPasswordAsync(user, loginViewModel.Password);

                    if (password)
                    {
                        var result = await this.signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);
                        if (result.Succeeded)
                            return RedirectToAction("Index", "Home");

                        ModelState.AddModelError(string.Empty, "Invalid Password");
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");

            }

            return View(loginViewModel);
        }
        #endregion

        #region Sign Out

        public async Task<IActionResult> SignOut()
        {
            await this.signInManager.SignOutAsync();
            return RedirectToAction("SignIn");

        }
        #endregion

        #region Forget Password

        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await this.userManager.FindByEmailAsync(forgetPasswordViewModel.Email);

                if(user is not null)
                {
                    var token =await this.userManager.GeneratePasswordResetTokenAsync(user);
                    var resetPasswordLink = Url.Action("ResetPassword", "Account", new {Email = forgetPasswordViewModel.Email, Token = token },Request.Scheme);

                    var email = new Email()
                    {
                        Title = "Reset Password",
                        Body = resetPasswordLink,
                        To = forgetPasswordViewModel.Email
                    };

                    EmailSettings.SendEmail(email);

                    return RedirectToAction("CompleteForgetPassword");
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");

            }
            return View(forgetPasswordViewModel);
        }
        #endregion

        public IActionResult CompleteForgetPassword()
        {
            return View();
        }
        public IActionResult ResetPassword(string email, string token)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await this.userManager.FindByEmailAsync(resetPasswordViewModel.Email);

                if (user is not null)
                {
                    var result = await this.userManager.ResetPasswordAsync(user, resetPasswordViewModel.Token, resetPasswordViewModel.Password);

                    if (result.Succeeded)
                        return RedirectToAction("ResetPasswordDone");

                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);

                }
                ModelState.AddModelError(string.Empty, "Invalid Email");

            }
            return View(resetPasswordViewModel);
        }

        public IActionResult ResetPasswordDone()
        {
            return View();
        }
    }
}
