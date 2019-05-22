using System.Diagnostics;

using Issue12492.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Issue12492.Controllers
{
    public class HomeController : Controller
    {
        private IStringLocalizer<HomeController> _l;

        public HomeController(IStringLocalizer<HomeController> l)
        {
            _l = l;
        }

        public IActionResult Index()
        {             
            string v = _l["abc"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
