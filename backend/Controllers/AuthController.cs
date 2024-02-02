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
        public ActionResult<LoginResponseDto> Login([FromBody] LoginDto dto)
        {
            string token = _authService.GenerateJwt(dto);
            var response = new LoginResponseDto
            {
                Token = token,
                Email = dto.Email
            };

            return Ok(response);
            
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
