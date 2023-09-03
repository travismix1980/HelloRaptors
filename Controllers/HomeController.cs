using Microsoft.AspNetCore.Mvc;

namespace HelloRaptors.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Content("Hello Toronto Raptors");
        }
    }
}
