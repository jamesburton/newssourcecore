using Microsoft.AspNetCore.Mvc;

namespace NewsSSourceCore
{
    public class HomeController : Controller
    {
        [Route("home/index")]
        public IActionResult Index()
        {
            return Ok("Hello World from a controller");
        }
    }
}