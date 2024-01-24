using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/children")]
    public class ChildController : ControllerBase
    {
        [HttpGet]
        public string GetAll()
        {
            return "All children";
        }

        [HttpPost]
        public string AddNewChild()
        {
            return "New kid added";
        }

        [HttpGet("{childId}")]
        public string GetChild([FromRoute]int childId)
        {
            return $"Kid {childId}";
        }

        [HttpPut("{childId}")]
        public string UpdateChild([FromRoute] int childId)
        {
            return $"Kid {childId} updated";
        }

        [HttpDelete("{childId}")]
        public string DeleteChild([FromRoute] int childId)
        {
            return $"Kid {childId} deleted";
        }
    }
}
