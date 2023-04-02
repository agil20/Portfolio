using FridayFilm.DAL;
using FridayFilm.Extentions;
using FridayFilm.Helper;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly Service service;
        private IConfiguration _config;

        public ProductController(AppDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager = null, Service service = null, IConfiguration config = null)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
            this.service = service;
            _config = config;
        }
        public IActionResult Index(int page = 1, int take = 5)
        {

            List<Film> products = _context.Films.Where(p => p.IsDelete == false).Include(p => p.FilmGenre).ThenInclude(f=>f.Genre).Skip((page - 1) * take).Take(take).ToList();

            PaginationVM<Film> paginationVM = new PaginationVM<Film>(products, PageCount(take), page);

           


            return View(paginationVM);


        }


        private int PageCount(int take)
        {
            List<Film> products = _context.Films.Include(f=>f.FilmGenre).ThenInclude(f => f.Genre).Where(p=>p.IsDelete==false).ToList();
            return (int)Math.Ceiling((decimal)products.Count() / take);

        }
        public async Task<IActionResult> Create()
        {

            ViewBag.Genre = new SelectList(_context.Genres.Where(f=>f.IsDelete==false).ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateVM product)
        {
            ViewBag.Genre = new SelectList(_context.Genres.Where(f => f.IsDelete == false).ToList(), "Id", "Name");

            if (product.Name == null)
            {
                ModelState.AddModelError("Name", "Cannot be Empty!");
                return View();
            }

            if (product.Photos == null)
            {
                ModelState.AddModelError("Photo", "Bosqoyma");
                return View();
            }
            if (!product.Photos.IsImage())
            {
                ModelState.AddModelError("Photo", "only Photo");
                View();

            }
            if (product.Photos.ValidSize(5000))
            {
                ModelState.AddModelError("Photo", "olcu uygun deyil");
                return View();

            }


            Film NewProduct = new Film
            {
             
                Name = product.Name,
                Desc = product.Desc,
               
             
                IsDelete = false,
              ImageUrl = product.Photos.SaveImage(_env, "img"),
         
                CreateTime = DateTime.Now,
               RealeaseYear=product.RealeaseYear,
               AgeLimit=product.AgeLimit,
               RunnigTime=product.RunnigTime,
               IMDB=product.IMDB,
               Fragman=product.Fragman,
               FilmUrl=product.FilmUrl,
               
               
              
            

            };

        
            if (product.GenreId != null)
            {
                List<FilmGenre> productTags = new List<FilmGenre>();
                foreach (int item in product.GenreId)
                {
                    FilmGenre productTag = new FilmGenre();
                    productTag.GenreId = item;
                    productTag.FilmId = NewProduct.Id;
                    productTags.Add(productTag);
                }
                NewProduct.FilmGenre = productTags;
            }

            await _context.AddAsync(NewProduct);
            await _context.SaveChangesAsync();

            List<  AppUser>  appUser=_userManager.Users.ToList();
                
                
                var token = "";
            string subject = "Endirim var!";
            EmailHelper helper = new EmailHelper(_config.GetSection("ConfirmationParam:Email").Value, _config.GetSection("ConfirmationParam:Password").Value);
            foreach (var receiver in appUser)
            {
                token = $"Salam. yeni Film artiq Ekranlarda xos seyirler. {product.Name} \n";

                var emailResult = helper.SendNews(receiver.Email, token, subject);
                continue;
            }
            string confirmation = Url.Action("ConfirmEmail", "Account", new
            {
                token
            }, Request.Scheme);


            return RedirectToAction("index");
        }
      
        public IActionResult Delete(int? id)
        {
            Film dbproduct = _context.Films.Include(p => p.FilmGenre).ThenInclude(f=>f.Genre).FirstOrDefault(p => p.Id == id);
            if (dbproduct==null)
            {
                return NotFound();
            }
                string path = Path.Combine(_env.WebRootPath, "img", dbproduct.ImageUrl);
                Helper.Helper.DeleteImage(path);
        

            dbproduct.IsDelete = true;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Genre = new SelectList(_context?.Genres?.ToList(), "Id", "Name");

            if (id == null) return RedirectToAction("error", "home");
          Film product = await _context.Films
               
                ?.Include(t => t.FilmGenre)
                ?.ThenInclude(p => p.Genre)
                ?.FirstOrDefaultAsync(c => c.Id == id);
            if (product == null) return RedirectToAction("error", "home");
            UpdateVM productUpdateVM = new UpdateVM
            {
                Name = product.Name,
                Desc = product.Desc,
               AgeLimit=product.AgeLimit,
               Countr=product.Countr,
               Fragman=product.Fragman,
               
               
            };
            return View(productUpdateVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, UpdateVM product)
        {
            ViewBag.Genre = new SelectList(_context.Genres.ToList(), "Id", "Name");
            if (!ModelState.IsValid)
            {
                return View();
            }
            Film dbProduct = await _context?.Films
               
                ?.Include(p => p.FilmGenre)
                .ThenInclude(t => t.Film)
              
                .Where(c => c.IsDelete != true)
                .FirstOrDefaultAsync(b => b.Id == id);
            if (dbProduct == null)
            {
                return View();
            }
          
          
            if (product.Photos == null)
            {
               dbProduct.ImageUrl=dbProduct.ImageUrl;
                
            }
            else
            {
              
                    if (product.Photos == null)
                    {
                        ModelState.AddModelError("Photo", "Can not be empty");
                        return View();
                    }
                    if (!product.Photos.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Only images");
                        return View();
                    }

                    if (product.Photos.ValidSize(20000))
                    {
                        ModelState.AddModelError("Photo", "The image size is larger than required size(max 20 mb)");
                        return View();
                    }
                dbProduct.ImageUrl = product.Photos.SaveImage(_env, "img");

             
            }

            if (product.GenreId == null)
            {
                foreach (var item1 in dbProduct.FilmGenre)
                {
                    item1.GenreId = item1.GenreId;
                }
            }
            else
            {
                List<FilmGenre> productTags = new List<FilmGenre>();
                foreach (int item in product.GenreId)
                {
                    FilmGenre productTag = new FilmGenre();
                    productTag.GenreId = item;
                    productTag.FilmId = dbProduct.Id;
                    productTags.Add(productTag);
                }
                dbProduct.FilmGenre = productTags;
            }

            dbProduct.Name = product.Name;
            dbProduct.Desc = product.Desc;
            dbProduct.AgeLimit = product.AgeLimit;
            dbProduct.Countr = product.Countr;
            dbProduct.Fragman = product.Fragman;
            dbProduct.RunnigTime = product.RunnigTime;

            dbProduct.Name = product.Name;
           
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)

        {
            if (id == null) return NotFound();
            Film product = await _context.Films.Include(f=>f.Comments).Include(p => p.FilmGenre).ThenInclude(f=>f.Genre).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

    }
}
