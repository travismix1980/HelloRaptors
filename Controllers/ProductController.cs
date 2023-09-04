using HelloRaptors.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloRaptors.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Product product = new();
            product.Title = "Basketball";
            product.Price = 19.99;

            return View(product);
        }
    }
}
