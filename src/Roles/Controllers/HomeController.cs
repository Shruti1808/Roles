using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Roles.Models;

namespace Roles.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(UserManager<ApplicationUser>
                              userManager)
        {
            this.userManager = userManager;
        }


        [Authorize]
        public IActionResult Index()
        {
            ApplicationUser user = userManager.GetUserAsync
                                 (HttpContext.User).Result;

            ViewBag.Message = $"Welcome {user.FullName}!";
            if (userManager.IsInRoleAsync(user, "NormalUser").Result)
            {
                ViewBag.RoleMessage = "You are a NormalUser.";
            }
            return View();
        }
    }
}
