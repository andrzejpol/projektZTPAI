using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService) 
        { 
            _authService = authService;
        }

        [HttpPost("login")]
        public string Login()
        {
            return "Login";
        }

        [HttpPost("register")]
        public ActionResult Register([FromBody] RegisterUserDto dto)
        {
            _authService.RegisterUser(dto);
            return Ok();
        }

        [HttpPost("logout")]
        public string Logout()
        {
            return "Logout";
        }


    }
}
