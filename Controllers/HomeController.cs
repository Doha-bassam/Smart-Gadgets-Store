using Microsoft.AspNetCore.Mvc;

namespace smartGadgetsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
