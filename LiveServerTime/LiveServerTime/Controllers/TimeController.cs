using Microsoft.AspNetCore.Mvc;

namespace LiveServerTime.Controllers
{
    [ApiController]
    [Route("Api/SetTime")]
    public class TimeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.Now.ToString("T"));
        }
    }
}
