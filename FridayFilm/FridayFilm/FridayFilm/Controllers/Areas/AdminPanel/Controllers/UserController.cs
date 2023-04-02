using FridayFilm.DAL;
using FridayFilm.Models;
using FridayFilm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayFilm.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]

    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly AppDbContext _context;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager, AppDbContext context = null)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
            _context = context;
        }

        public IActionResult Index(string search)
        {
            var users = search == null ?
                _userManager.Users.ToList() : _userManager.Users.
                Where(user => user.UserName.ToLower().Contains(search.ToLower())).ToList();


            return View(users);
        }
        public async Task<IActionResult> Update(string id)

        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            var roles = _rolemanager.Roles.ToList();
            RoleVM roleVM = new RoleVM
            {
                FullName = user.UserName,
                Roles = roles,
                UserRoles = userRoles,
                UserId = user.Id


            };
            return View(roleVM);

        }
        [HttpPost]
        public async Task<IActionResult> Update(List<string> roles, string id)

        {
            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            await _userManager.AddToRolesAsync(user, roles);


            return RedirectToAction("index");
        }
    
        public async Task<IActionResult> Detail(string Id)

        {
            List<Comment> comments = _context.Comments.Where(c => c.AppUserId == Id).ToList();


            return View(comments);
        }
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            List<Comment> comments = _context.Comments.Where(b => b.AppUserId == user.Id).ToList();
            foreach (var item in comments)
            {
                _context.Remove(item);
            }


            await _userManager.DeleteAsync(user);

            return RedirectToAction("index");
        }

    }
}
