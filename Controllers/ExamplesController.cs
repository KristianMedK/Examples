using Microsoft.AspNetCore.Mvc;

namespace ExamplesApi.Controllers
{
    [Route("api/v1/exampless")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            //Get data from database
            return Ok("FLAF");
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            //Save data to database
            return Ok("FLIF");
        }
    }
}