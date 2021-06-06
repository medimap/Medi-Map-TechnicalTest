using Microsoft.AspNetCore.Mvc;


namespace TechnicalTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok($"Welcome to Medi-Map Technical Test!");
        }

    }
}
