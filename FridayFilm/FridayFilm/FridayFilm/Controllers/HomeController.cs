using FridayFilm.DAL;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(AppDbContext context, UserManager<AppUser> userManager)
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
            ViewBag.ProductCount = _context.Films.Where(f=>f.IsDelete==false).Count(); ;

            List<Film> Films = _context.Films.Where(f=>f.IsDelete==false).Take(2).Include(f=>f.FilmGenre).ToList();
            List<Genre> Genres = _context.Genres.Include(f => f.FilmGenre).ToList();
            List<Film> FilmsLoad = _context.Films.Where(f => f.IsDelete == false).Take(2).Include(f => f.FilmGenre).ToList();
          




            HomeVM home =new HomeVM();
      
            home.Films= Films;
            home.Genres= Genres;
            home.FilmsLoad = FilmsLoad;

            
            
            return View(home);
        }
        public IActionResult Search(string search)
        {
         

            List<Film> products = _context.Films
               
           .Where((p => p.Name.ToLower().Contains(search.ToLower()) ||p.Desc.ToLower().Contains(search.ToLower()) ) ).Take(5).Where(p=>p.IsDelete==false).ToList();
            if (products == null)
            {
                return RedirectToAction("error", "home");
            }
        

            return PartialView("_Search", products);
        }
        private  int PageCount(int take)
        {
          
            List<Film> films = _context.Films.ToList();
            return (int)Math.Ceiling((decimal)films.Count() / take);

        }
        public IActionResult LoadMore(int skip)
        {
         

            List<Film> films = _context.Films.Where(f => f.IsDelete == false).Skip(skip).Take(2).Include(p => p.FilmGenre).ThenInclude(p=>p.Genre).ToList();
          
            return PartialView("ShowMorePartial", films);
        }
        public IActionResult LoadMor(int skip)
        {



            List<Film> Films = _context.Films.Where(f=>f.IsDelete==false).Skip(skip).Take(2).Include(f => f.FilmGenre).ToList();
            return PartialView("_loadMorePartial", Films);
        }
        public async Task<IActionResult> Detail(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                ViewBag.Comment = false;
            }
            else
            {
                ViewBag.Comment = true;


            } if (User.Identity.IsAuthenticated)
            {
                AppUser appuser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (appuser.AbuneEnd < DateTime.Now)
                {
                    appuser.Abune = false;

                }

            }

            Film films = _context.Films.Include(f => f.FilmGenre).Include(c => c.Comments).FirstOrDefault(f => f.Id == id);
            List<Film> film = _context.Films.Where(f => f.IsDelete == false).Include(f => f.FilmGenre).ThenInclude(f => f.Genre).Take(4).ToList();
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = appUser.Id;
                ViewBag.UserVatch = appUser.Abune;
                int RightCounter = 0;
                var roles = await _userManager.GetRolesAsync(appUser);
                foreach (var item in roles)
                {
                    if (item.ToLower().Contains("admin")|| item.ToLower().Contains("superadmin"))
                    {
                        RightCounter++;
                    }
                }
                ViewBag.RightCounter = RightCounter;
            }
            else
            {
                ViewBag.UserVatch = false;
            }


            DetailVM detailVM = new DetailVM();
            detailVM.film = films;
            detailVM.Films = film;

            return View(detailVM);



        }


        [Authorize]
        public async Task<IActionResult> Comment(string comment, int Id)
        {

                Film films = _context.Films.FirstOrDefault(f => f.Id == Id);
               
            if (comment!=null)
            {
                Comment newcomment = new Comment();
                newcomment.Text = comment;
                newcomment.CreateComment = DateTime.Now;
                newcomment.FilmId = Id;

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                newcomment.AppUserId = user.Id;
                newcomment.AppUser = user;
                newcomment.Author = user.UserName;
                _context.Add(newcomment);
                _context.SaveChanges();
            }


                
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = appUser.Id;
                ViewBag.UserVatch = appUser.Abune;
                int RightCounter = 0;
                var roles = await _userManager.GetRolesAsync(appUser);
                foreach (var item in roles)
                {
                    if (item.ToLower().Contains("admin") || item.ToLower().Contains("superadmin"))
                    {
                        RightCounter++;
                    }
                }
                ViewBag.RightCounter = RightCounter;
            }
            else
            {
                ViewBag.UserVatch = false;
            }
            List<Comment> comments = _context.Comments.Include(c => c.AppUser).Where(c => c.FilmId == films.Id).ToList();
          
            
                return PartialView("_CommentPartial", comments);
            
              
            

        

        }
       

        public async Task< IActionResult> Delete(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appuser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (appuser.AbuneEnd < DateTime.Now)
                {
                    appuser.Abune = false;

                }

            }

            Comment comment =  _context.Comments.FirstOrDefault(f => f.Id == Id);
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = appUser.Id;
                ViewBag.UserVatch = appUser.Abune;
                int RightCounter = 0;
                var roles = await _userManager.GetRolesAsync(appUser);
                foreach (var item in roles)
                {
                    if (item.ToLower().Contains("admin") || item.ToLower().Contains("superadmin"))
                    {
                        RightCounter++;
                    }
                }
                ViewBag.RightCounter = RightCounter;
            }
            else
            {
                ViewBag.UserVatch = false;
            }
            _context.Comments.Remove(comment);
            _context.SaveChanges();

            return Ok();

        }


    }
}
