using dailypink.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dailypink.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public WelcomeController(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await (from product in _context.Products
                           join category in _context.Categories
                           on product.Id equals category.Id into PCJoin
                           from category in PCJoin.DefaultIfEmpty()
                           select new ProductViewModel()
                           {
                               Id = product.Id,
                               Name = product.Name, 
                               Description = product.Description,
                               CategoryName = category.Name,
                           }).ToListAsync();

            return View();
        }
    }
}
