using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.DAL.Entites;
using MVC.PL.Models.Account;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.PL.Controllers
{
    [Authorize(Roles = "Admin , IT")]
    //[Authorize(Roles = "IT")]

    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = this.roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole identityRole)
        {
            if (ModelState.IsValid)
            {
                var result = await this.roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                    return RedirectToAction("Index");

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);

                return View(identityRole);

            }
            return View(identityRole);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id is null)
                return NotFound();

            var role = await this.roleManager.FindByIdAsync(id);

            if (role is null)
                return NotFound();

            return View(role);
        }

        public async Task<IActionResult> Update(string id)
        {
            if (id is null)
                return NotFound();

            var role = await this.roleManager.FindByIdAsync(id);

            if (role is null)
                return NotFound();

            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string id, IdentityRole identityRole)
        {
            if (id != identityRole.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    var role = await this.roleManager.FindByIdAsync(id);

                    role.Name = identityRole.Name;
                    role.NormalizedName = identityRole.Name.ToUpper();

                    var result = await this.roleManager.UpdateAsync(role);

                    if (result.Succeeded)
                        return RedirectToAction("Index");

                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            return View(identityRole);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id is null)
                return NotFound();


            try
            {
                var role = await this.roleManager.FindByIdAsync(id);

                var result = await this.roleManager.DeleteAsync(role);

                if (result.Succeeded)
                    return RedirectToAction("Index");

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            catch (System.Exception)
            {
                throw;
            }

            return View();
        }

        public async Task<IActionResult> AddOrRemoveUsers(string RoleId)
        {
            var role = await this.roleManager.FindByIdAsync(RoleId);

            if (role is null)
                return NotFound();

            ViewBag.RoleId = RoleId;

            var users = new List<UserInRoleViewModel>();

            foreach (var user in this.userManager.Users)
            {
                var userInRole = new UserInRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                };

                if (await this.userManager.IsInRoleAsync(user, role.Name)) 
                    userInRole.IsSelected = true;
                else 
                    userInRole.IsSelected = false;

                users.Add(userInRole);
            }

            return View(users);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrRemoveUsers(List<UserInRoleViewModel> models, string RoleId)
        {
            var role = await this.roleManager.FindByIdAsync(RoleId);

            if (role is null)
                return NotFound();

            if (ModelState.IsValid)
            {
                foreach (var item in models)
                {
                    var user = await this.userManager.FindByIdAsync(item.UserId);
                    if (user is not null)
                    {
                        if(item.IsSelected && !(await this.userManager.IsInRoleAsync(user, role.Name)))
                            await this.userManager.AddToRoleAsync(user, role.Name);
                        else if(!item.IsSelected && (await this.userManager.IsInRoleAsync(user, role.Name)))
                            await this.userManager.RemoveFromRoleAsync(user, role.Name);

                    }
                }
                return RedirectToAction("Update", new {id = RoleId});
            }

            return View(models);
        }
    }
}
