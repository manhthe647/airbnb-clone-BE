using airbnb_clone_BE.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace airbnb_clone_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalacesController : ControllerBase
    {
        private readonly IPalaceService _palaceService;
        public PalacesController(IPalaceService palaceService)
        {
            _palaceService = palaceService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _palaceService.GetDataPaging();
            return Ok(result);
        }
    }
}
