﻿using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static FridayFilm.Helper.Helper;

namespace FridayFilm.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountController(RoleManager<IdentityRole> rolemanager, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager = null)
        {
            _rolemanager = rolemanager;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = new AppUser
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email

            };
            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerVM);
            }
            await _signInManager.SignInAsync(user, true);
            await _userManager.AddToRoleAsync(user, UserRoles.Member.ToString());

            return RedirectToAction("index", "home");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM, string ReturnUrl)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "email ve ya password invalid");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, true, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Bloklandiniz");
                return View();
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "email ve ya password invalid");
                return View();
            }
            await _signInManager.SignInAsync(appUser, true);
            var role = await _userManager.GetRolesAsync(appUser);

            foreach (var item in role)
            {
                if (item == "Admin")
                {
                    return RedirectToAction("Index", "dashboard", new { area = "AdminPanel" });
                }
            }
            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("index", "home");
        }
        public async Task CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(UserRoles)))
            {
                if (!await _rolemanager.RoleExistsAsync(item.ToString()))
                {
                    await _rolemanager.CreateAsync(new IdentityRole { Name = item.ToString() });
                }
            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login");
        }

    }
}
