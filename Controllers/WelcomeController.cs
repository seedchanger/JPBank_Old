using Microsoft.AspNetCore.Mvc;

namespace JPBank.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
