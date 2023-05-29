using HotelProject.Model;
using HotelProject.Services.VisitorFunctionService;
using HotelProject.Services.VisitorService;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorFunctionController : ControllerBase
    {
        private readonly IVisitorFunctionService _visitorFunctionService;

        public VisitorFunctionController(IVisitorFunctionService visitorFunctionService)
        {
            _visitorFunctionService = visitorFunctionService;
        }
        [HttpGet("{location}")]
        public async Task<ActionResult<object>> Filter(string location)
        {
            var visitor = await _visitorFunctionService.Filter(location);
            if (visitor == null)
            {
                return NotFound("visitor_id Not Available");
            }
            return Ok(visitor);
        }
    }
}
