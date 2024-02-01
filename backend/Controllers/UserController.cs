using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Authorize]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string GetAll()
        {
            return "Hello";
        }

        [HttpGet("{userId}")]
        public string GetUser([FromRoute] int userId)
        {
            return $"Hello it's userid {userId}";
        }

        [HttpPut("{userId}")]
        public string EditUser([FromRoute] int userId)
        {
            return $"User {userId} has been edited.";
        }

        [HttpDelete("{userId}")]
        public string DeleteUser([FromRoute] int userId)
        {
            return $"User {userId} has been deleted";
        }
    }
}
