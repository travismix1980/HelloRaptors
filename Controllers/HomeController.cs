using Microsoft.AspNetCore.Mvc;

namespace HelloRaptors.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Models.Raptors player = new()
            {
                PlayerName = "Kyle Lowry",
                ArrivalDate = new(2012, 3, 24),
            };
            return View(player);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return Content("Edit");
        }
    }
}
