using CarTender.ApiServices;
using CarTender.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarTender.Controllers
{
    public class SignUpController : Controller
    {
        SignUpApiServices _signUpApiServices;

        public SignUpController(SignUpApiServices signUpApiServices)
        {
            _signUpApiServices = signUpApiServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            AddSignUpDTO dto = new AddSignUpDTO();
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddSignUpDTO dto)
        {
            dto.RoleID = 2;
            var request = await _signUpApiServices.AddSignUpUser(dto);
            return View();
        }
    }
}
