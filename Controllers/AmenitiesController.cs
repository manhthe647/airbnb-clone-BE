using airbnb_clone_BE.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace airbnb_clone_BE.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {
        private readonly IAmenityService _amenityService;

        public AmenitiesController(IAmenityService amenityService)
        {
            _amenityService = amenityService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            var rs= await _amenityService.GetAmenity();
            return Ok(rs);
        }
    }
}
