using FridayFilm.DAL;
using FridayFilm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public PricingController(AppDbContext context, SignInManager<AppUser> signInManager = null, UserManager<AppUser> userManager = null)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user.AbuneEnd<DateTime.Now)
                {
                    user.Abune = false;

                }

            }
            List<Pricing> pricingList = _context.Pricings.ToList();
          
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.Balans = user.Abune;
           
            }
            else
            {
                ViewBag.Balans = false;
               
            }
          
            return View(pricingList);
        }
      
       
        public async Task<IActionResult> Abune(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appuser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (appuser.AbuneEnd < DateTime.Now)
                {
                    appuser.Abune = false;

                }

            }
            if (!User.Identity.IsAuthenticated)
            {
                var obj1 = new
                {
                    Abune = 4,

                };

                return Json(obj1);
            }
            AppUser user =  await _userManager.FindByNameAsync(User.Identity.Name);
          Pricing pricing=_context.Pricings.FirstOrDefault(p => p.Id == id);
            if (user.Balance<pricing.Price)
            {
                var obj1 = new
                {
                    Abune = 3,

                };

                return Json(obj1);

            }
            if (user.Abune)
            {
                var obj1 = new
                {
                    Abune = 1,

                };

                return Json(obj1);
            }
            user.AbuneStard = DateTime.Now;
            user.AbuneEnd = user.AbuneStard.AddDays(pricing.Date);
           

            user.Abune = true;
            user.Balance -= pricing.Price;
          
        
            _context.SaveChanges(); 
            var obj = new
            {
                Abune=2
            };
            return Json(obj);
        }
      
    }
}
