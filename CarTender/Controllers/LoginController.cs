using Microsoft.AspNetCore.Mvc;

namespace CarTender.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
