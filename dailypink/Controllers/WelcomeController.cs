using Microsoft.AspNetCore.Mvc;

namespace dailypink.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
