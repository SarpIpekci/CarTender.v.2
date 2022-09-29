using Microsoft.AspNetCore.Mvc;

namespace CarTender.Controllers
{
    public class EmailVerificationCorrectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
