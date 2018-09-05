using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var response = "oh hi mark!";
            _logger.LogInformation($"{response} : {DateTime.UtcNow}");
            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            _logger.LogInformation($"Call received from client:{id}");
            return id.ToString();
        }
    }
}
