namespace NSwagStringEnum.WebApi.Controllers
{
    using Data;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger) => _logger = logger;

        [HttpPost]
        public string Post([FromBody] SimpleThing thing)
        {
            _logger.LogInformation(
                "User sent {String} and: {Enum} + {OtherEnum}",
                thing.Name,
                thing.FancyThing,
                thing.OtherThing);

            return "OK";
        }
    }
}
