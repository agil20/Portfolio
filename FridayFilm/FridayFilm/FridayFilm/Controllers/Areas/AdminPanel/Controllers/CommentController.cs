using FridayFilm.DAL;
using FridayFilm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class CommentController : Controller
    {
        private readonly AppDbContext _context;

        public CommentController(AppDbContext context)
        {
            _context = context;

        }

        public IActionResult  Index()
        {

           List<Comment> comments =  _context.Comments.Include(c=>c.Film).ToList();
            return View(comments);
      

        }

        public async Task<IActionResult>  Delete(int id)
        {

            Comment comments =  await _context.Comments.FindAsync(id);
            _context.Comments.Remove(comments);
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
