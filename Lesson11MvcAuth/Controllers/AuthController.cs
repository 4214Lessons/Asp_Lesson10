using Lesson11MvcAuth.Data;
using Lesson11MvcAuth.Encryptors;
using Lesson11MvcAuth.Models;
using Lesson11MvcAuth.Models.ViewModels;
using Lesson11MvcAuth.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace Lesson11MvcAuth.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserManager userManager;

        public AuthController(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (userManager.Register(model.Login, model.Password, false))
                        return RedirectToAction("Login");

                    ModelState.AddModelError("All", "Login is allready taken");
                }
                return View(model);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (userManager.Login(model.Login, model.Password))
                    return RedirectToAction("Index", "Home");
                ModelState.AddModelError("All", "Incorrect login or password");
            }

            return View(model);
        }

    }
}
