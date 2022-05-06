using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers
{
    [Controller]
    [Route("api/[action]")]
    public class HelloController : ControllerBase
    {

        public ActionResult Hello()
        {
            return Ok("Hello world");
        }
    }
}
