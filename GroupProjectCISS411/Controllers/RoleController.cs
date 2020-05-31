using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using GroupProjectCISS411.Models;
using GroupProjectCISS411.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupProjectCISS411.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        ApplicationDbContext db;
        UserManager<ApplicationUser> userManager;
        RoleManager<IdentityRole> roleManager;
        public RoleController(ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        // GET: /<controller>/
        public IActionResult AllRole()
        {
            var roles = roleManager.Roles.ToList();
            return View();
        }
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            var result = await roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("AllRole");
            }
            return View();
        }
        public async Task<IActionResult> AddUserRole(string id)
        {
            var roleDisplay = db.Roles.Select(x => new
            {
                Id = x.Id,
                Value = x.Name
            }).ToList();
            AdminAddUserRoleViewModel vm = new AdminAddUserRoleViewModel();
            var user = await userManager.FindByIdAsync(id);
            vm.User = user;
            vm.RoleList = new SelectList(roleDisplay, "Id", "value");
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddUserRole(AdminAddUserRoleViewModel vm)
        {
            var user = await userManager.FindByIdAsync(vm.User.Id);
            var role = await roleManager.FindByIdAsync(vm.Role);
            var result = await userManager.AddToRoleAsync(user, role.Name);
            if (result.Succeeded)
            {
                return RedirectToAction("AllUser", "Account");
            }
            foreach(var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
            var roleDisplay = db.Roles.Select(x => new
            {
                Id = x.Id,
                Value = x.Name
            }).ToList();
            vm.User = user;
            vm.RoleList = new SelectList(roleDisplay, "Id", "Value");
            return View(vm);
        }
    }
}
