using Microsoft.AspNetCore.Mvc;

namespace APICarTender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        [HttpPost]
        public bool SaveUserPost()
        {
            return true;
        }
    }
}
