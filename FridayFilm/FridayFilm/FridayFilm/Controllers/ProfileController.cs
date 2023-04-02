using FridayFilm.DAL;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appuser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (appuser.AbuneEnd < DateTime.Now)
                {
                    appuser.Abune = false;

                }

            }
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            List<Comment> comments = _context.Comments.Where(p => p.AppUserId == user.Id).ToList();
            ProfileVM profile = new ProfileVM();
            profile.AppUser = user;
            profile.Comments = comments;
           
            return View(profile);
        }
       
       
        public  IActionResult Cardto()
        {
          
            return View();


        }
        [HttpPost]
        public async Task<IActionResult> Card(CartoVM card)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appuser = await _userManager.FindByNameAsync(User.Identity.Name);
             appuser.Balance=   appuser.Balance  +card.Price;

            }
            _context.SaveChanges();
            return RedirectToAction("index");

        }




    }
}
