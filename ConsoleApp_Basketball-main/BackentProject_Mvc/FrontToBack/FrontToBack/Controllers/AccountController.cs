﻿using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static FrontToBack.Helpers.Helpers;

namespace FrontToBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole>rolemanager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = new AppUser {
            FullName=register.FullName,
            UserName=register.UserName,
             Email=register.Email
            };
     IdentityResult result=    await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded) 
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
                return View(register);
            
            }
         
            await _userManager.AddToRoleAsync(user, UserRoles.Member.ToString());
            return RedirectToAction("index", "Home");

        }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM,string ReturnUrl )
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
            var roles = await _userManager.GetRolesAsync(appUser);
            foreach (var item in roles)
            {
                if (item=="Admin")
                {
                    return RedirectToAction("index", "dashboard", new { area="AdminPanel"});

                }
            }

            if (ReturnUrl!=null)
            {
                return Redirect(ReturnUrl);
            }


            return RedirectToAction("index", "Home");
        }

        public async Task<IActionResult> Logout()

        { 
        await _signInManager.SignOutAsync();

            return RedirectToAction("Login");  
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


    }
}
