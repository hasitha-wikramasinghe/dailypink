using Microsoft.AspNetCore.Mvc;

namespace dailypink.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
