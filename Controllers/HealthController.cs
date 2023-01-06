using LogUtility;
using Microsoft.AspNetCore.Mvc;

namespace AzureAdApi.Controllers
{
    [Route("api/v1")]
    public class HealthController : ControllerBase
    {
        private readonly ILog _log;

        public HealthController(ILog log)
        {
            _log = log;
        }

        [HttpGet("ping")]
        public ActionResult Ping()
        {
            return Ok("Pong");
        }

        [HttpGet("logtest")]
        public ActionResult LogTest()
        {
            _log.LogInformation("Log information");
            _log.LogWarning("Log warning");
            _log.LogError("Log error");

            return Ok();
        }
    }
}