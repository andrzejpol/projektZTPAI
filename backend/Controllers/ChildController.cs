using backend.Entities;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/children")]
    //[Authorize]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        //[Authorize(Roles = "Admin,Manager")]
        public ActionResult<IEnumerable<Child>> GetAll()
        {
            var children = _childService.GetChildren();

            return Ok(children);
        }

        [HttpPost]
        public ActionResult AddNewChild([FromBody] Child child)
        {
            _childService.AddChild(child);
            return Ok();
        }

        [HttpGet("{childId}")]
        public ActionResult<Child> GetChild([FromRoute]int childId)
        {
            var child = _childService.GetChildById(childId);
            if(child == null) 
            {
                return NotFound();
            }
            return Ok(child);
        }

        [HttpPut("{childId}")]
        public ActionResult UpdateChild([FromRoute] int childId, [FromBody] Child child)
        {
            if(childId != child.Id)
            {
                return BadRequest();
            }

            _childService.UpdateChildById(childId,child);
            return NoContent();
        }

        [HttpDelete("{childId}")]
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult DeleteChild([FromRoute] int childId)
        {
            var child = _childService.GetChildById(childId);
            if( child == null )
            {
                return NotFound();
            }

            _childService.DeleteChild(childId);
            return Ok();
        }
    }
}
