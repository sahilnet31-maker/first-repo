using Microsoft.AspNetCore.Mvc;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DestinationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var destinations = new[]
            {
                new { Id = 1, Name = "Pariss" },
                new { Id = 2, Name = "New York" },
                new { Id = 3, Name = "Tokyo" }
            };
            return Ok(destinations);
        }
    }
}
