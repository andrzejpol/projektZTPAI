using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public string Login()
        {
            return "Login";
        }

        [HttpPost("register")]
        public string Register()
        {
            return "Register";
        }

        [HttpPost("logout")]
        public string Logout()
        {
            return "Logout";
        }


    }
}
