using FridayFilm.DAL;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]

    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Pricing> pricings = _context.Pricings.ToList();
            return View(pricings);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCardVM card )
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Pricing pricing = new Pricing
            {
                Name = card.Name,
                Price = card.Price,
                Date=card.Date,
                Duration=card.Duration
            };
            _context.Pricings.Add(pricing);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            Pricing pricing = _context.Pricings.Find(id);
            return View(pricing);

        }
        [HttpPost]
        public IActionResult Update(CardUpdateVM card)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Pricing pricing = _context.Pricings.FirstOrDefault(c => c.Id == card.Id);

           
            if (card.Name!=null)
            {
                pricing.Name = card.Name;
            }
            if (card.Price!=0)
            {
                pricing.Price=card.Price;
            }
            if (card.Date!=0)
            {
                pricing.Date = card.Date;
            }
            if (card.Duration!=null)
            {
                pricing.Duration = card.Duration;
            }
            _context.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Delete(int Id)
        {
            Pricing pricing = _context.Pricings.FirstOrDefault(c=>c.Id==Id);
            _context.Remove(pricing);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
