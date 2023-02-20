using Microsoft.AspNetCore.Mvc;

namespace MBCW.Controllers
{
    public class MainPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
