using HelloRaptors.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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

            CookieOptions cookieOptions = new();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));

            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions);
                return Content("Welcome New Visitor");
            }
            else
            {
                DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_request"]);
                return Content($"Welcome Back User!  You first visited us on {firstRequest}");
            }
            
            //return View(player);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return Content("Edit");
        }

        [HttpGet]
        public IActionResult SimpleBinding()
        {
            Player p = new();
            p.PlayerName = "Kyle Lowry";
            p.Position = "Guard";

            return View(p);
        }

        [HttpPost]
        public IActionResult SimpleBinding(Player raptor)
        {
            if (ModelState.IsValid)
            {
                return Content($"{raptor.PlayerName} updated!");
            } 
            else
            {
                return View(raptor);
            }
        }

        public IActionResult QueryTest()
        {
            var name = "Pascal Siakim";
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["name"]))
            {
                name = HttpContext.Request.Query["name"];
            }
            return Content($"Name from query string is: {name}");
        }
    }
}
