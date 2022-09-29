using Microsoft.AspNetCore.Mvc;

namespace CarTender.Controllers
{
    public class EmailVerificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
