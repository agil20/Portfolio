using FridayFilm.DAL;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Controllers
{
    public class CatalogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CatalogController(AppDbContext context, UserManager<AppUser> userManager = null)
        {
            _context = context;
            _userManager = userManager;
        }
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

            CatalogVM catalogVm = new CatalogVM();
         
            List<Genre> genre = _context.Genres.Include(g => g.FilmGenre).Where(g=>g.IsDelete==false).ToList();

            List<Film> filmGenres = _context.Films.Include(g => g.FilmGenre).ToList();

         
         
            catalogVm.Film = filmGenres;
            catalogVm.FilmGenresAll = genre;

            return View( catalogVm);


        }
        public IActionResult SortGenre(int id)
        {
                   

        List<FilmGenre> filmgemres = _context.FilmGenres.Where(g=>g.Film.IsDelete==false).Where(f => f.GenreId == id).ToList();
            List<Film> Films = new List<Film>();
            foreach (var item in filmgemres)
            {
                Film film = _context.Films.Include(f=>f.FilmGenre).Where(f=>f.IsDelete==false).FirstOrDefault(f => f.Id == item.FilmId);
                Films.Add(film);
            }




            return PartialView("_CatalogPartial", Films);


        }

        public IActionResult SortMinMax(int min)
        {
            List<Film> dBproducts = _context.Films.Where(f => f.IsDelete == false).ToList();
            if (min == 2)
            {
                List<Film> products = _context.Films.Where(f=>f.IsDelete==false).OrderBy(p => p.IMDB).ToList();
                return PartialView("_CatalogPartial", products);

            }
            return PartialView("_CatalogPartial", dBproducts);
        }



    }
}
