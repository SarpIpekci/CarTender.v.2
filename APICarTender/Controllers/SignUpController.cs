using APIApplication.Abstract;
using APIModels.DTOS.SignUp;
using Microsoft.AspNetCore.Mvc;

namespace APICarTender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        ISignUpService _service;
        public SignUpController(ISignUpService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult SaveUserPost(RegisterDTO dto)
        {
            var result = _service.AddUser(dto);
            return Ok(result);
        }
    }
}
