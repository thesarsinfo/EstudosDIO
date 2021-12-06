using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Localiza.Frotas.Infra.Singleton;

namespace Localiza.Frotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            var singleton = Singleton.Instance;
            return Ok(singleton);
        }
    }
}
