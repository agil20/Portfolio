using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class BasketController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddItem(int? id)
        {
          
            if (id == null) return NotFound();

            Product dbProduct = await _context.Products.FindAsync(id);
           // if (!(dbProduct.Count > 0)) return NotFound();
            

            
            if (dbProduct == null) return NotFound();
            List<BasketVM> products;
            if (Request.Cookies["basket"] == null)




            {
                products = new List<BasketVM>();
            }
            else {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            BasketVM existProduct = products.Find(x => x.Id == id);
            if (existProduct == null)
            {
                BasketVM basketVM = new BasketVM
                {
                    Id = dbProduct.Id,
                    Price = dbProduct.Price,
                    ImageUrl = dbProduct.ImageUrl,
                    CategoryId = dbProduct.CategoryId,
                    Name = dbProduct.Name,
                    ProductCount = 1


                };
                products.Add(basketVM);
            }
            else 
            {
                existProduct.ProductCount++;
            
            
            }
     
         
            Response.Cookies.Append("basket",JsonConvert.SerializeObject(products),new CookieOptions { MaxAge=TimeSpan.FromDays(5)});
            return RedirectToAction("index","home");
        }
        public IActionResult ShowItem()
        {

            string basket = Request.Cookies["basket"];
            List<BasketVM> products;
            if (basket != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                foreach (var item in products)
                {
                    Product dbProduct = _context.Products.FirstOrDefault(x => x.Id == item.Id);
                    item.Price = dbProduct.Price;
                    item.ImageUrl = dbProduct.ImageUrl;
                    item.CategoryId = dbProduct.CategoryId;
                    item.Name = dbProduct.Name;


                }
            }
            else 
            {
                products=new List<BasketVM>();


            }
            
            
            return View(products);
        }
        public IActionResult Delete(int? id)
        {
            List<BasketVM> basketVMs;
            string basket = Request.Cookies["basket"];
           basketVMs =   JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            basketVMs.RemoveAll(p => p.Id == id);
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketVMs), new CookieOptions { MaxAge = TimeSpan.FromDays(5) });
        
            return Json(basketVMs.Count);

        }
        public IActionResult Plus(int? id)
        {
            Product dbproduct = _context.Products.FirstOrDefault(x => x.Id == id);


            List<BasketVM> products;

            string basket = Request.Cookies["basket"];
            products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = products.Find(p => p.Id == id);


            if (dbproduct.Count > product.ProductCount)
            {
                product.ProductCount = product.ProductCount + 1;
            }
            product.ProductCount = product.ProductCount ;
            product.Sum = product.Price * product.ProductCount;

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var productPlusObj = new
            {
                productCount = product.ProductCount,
                productSum=product.Sum,
               dbProductCount=dbproduct.Count


            };
            return Json(productPlusObj);
        }
        public IActionResult Minus(int? id)
        {
            Product dbproduct = _context.Products.FirstOrDefault(x => x.Id == id);


            List<BasketVM> products;
            string basket = Request.Cookies["basket"];
            products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = products.Find(p => p.Id == id);

           
            product.ProductCount = product.ProductCount -1;
            product.Sum = product.Price * product.ProductCount;
            if (product.ProductCount==0)
            {
                products.Remove(product);
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
           
            var productPlusObj = new
            {
                productCount = product.ProductCount,
                productSum = product.Sum,
                dbProductCount = dbproduct.Count
            };
            return Json(productPlusObj);
        }
        [HttpPost]
      //  [ActionName("Basket")]
        public async Task<IActionResult> Sale()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                Sale sale = new Sale();
                sale.SaleDate = DateTime.Now;
                sale.AppUserId = user.Id;
                List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                List<SalesProduct> salesProducts = new List<SalesProduct>();
                int Total = 0;
             

                foreach (var basketProduct in basketProducts)
                {
                    Product product = await _context.Products.FindAsync(basketProduct.Id);

                    if (basketProduct.ProductCount < product.Count)
                    {
                        TempData["fail"] = "o qeder product yoxdur";
                        return RedirectToAction("ShowItem");
                    }

                    SalesProduct sales = new SalesProduct();
                    sales.ProductId = product.Id;
                    sales.Count = basketProduct.ProductCount;
                    sales.SaleId = sale.Id;
                    sales.Price = product.Price;
                   
                    Total += basketProduct.ProductCount * product.Price;
              product.Count-= basketProduct.ProductCount;
                  

                }
                sale.SalesProducts = salesProducts;
                sale.Total = Total;
             
                await _context.AddAsync(sale);
                await _context.SaveChangesAsync();

               
              

                TempData["succes"] = "Sale succesdir";

                return RedirectToAction("ShowItem");
            
            }
            else
            {
                return RedirectToAction("login","account");
            }
        
        
        }
    }
}
