using Microsoft.AspNetCore.Mvc;

namespace AvitoTradeApp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}