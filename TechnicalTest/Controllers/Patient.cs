using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TechnicalTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Patient : ControllerBase
    {
    
        [HttpPost]
        public void Post([FromBody] PatientDetails value)
        {
         
        }
    }
}
