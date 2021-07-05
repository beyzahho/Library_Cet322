using Microsoft.AspNetCore.Mvc;

namespace LibraryCet322.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "My application description page.";

            return View();
        }

     
        public IActionResult Contact()
        {

            ViewData["Message"] = "My contact page.";

            return View();
        }
        public IActionResult Error()
        {

      return View();
        }
    }
}
