using Microsoft.AspNetCore.Mvc;

namespace ServiceExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            // throw new Exception("There was an error");
            return new string[] { "Value 1", "Value 2" };
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return id.ToString();
        }
    }
}
