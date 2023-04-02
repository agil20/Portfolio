using FridayFilm.DAL;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class GenreController : Controller
    {
      
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public GenreController(AppDbContext context, IWebHostEnvironment env, Service service)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Genre> categories = _context.Genres.Where(f=>f.IsDelete==false).ToList();
            return View(categories);

        }
        public async Task<IActionResult> Create()
        {

            return View();
        }
        public async Task<IActionResult> Update(int? id)

        {
            if (id == null) return NotFound();
            Genre category = await _context.Genres.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateGenreVm category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
          
            Genre dbCategory = _context.Genres.FirstOrDefault(c => c.Id == category.Id);
            Genre dbCategoryName = _context.Genres.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());
            if (dbCategoryName != null)
            {
                if (dbCategoryName.Name != dbCategory.Name)
                {
                    ModelState.AddModelError("Name", "bu adli category var");
                    return View();
                }
            }

           
            dbCategory.Name = category.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genre genre)
        {
         

            if (genre.Name == null)
            {
                ModelState.AddModelError("Name", "Cannot be Empty!");
                return View();
            }

          
         


            Genre NewProduct = new Genre
            {

                Name = genre.Name,
              

                IsDelete = false,
             
            };


          
            await _context.AddAsync(NewProduct);
            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }
        public IActionResult Delete(int? id)
        {
            Genre dbproduct = _context.Genres.FirstOrDefault(p => p.Id == id);
            if (dbproduct == null)
            {
                return NotFound();
            }
            _context.Remove(dbproduct);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
