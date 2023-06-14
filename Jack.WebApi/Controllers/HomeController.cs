using Microsoft.AspNetCore.Mvc;
using System;

namespace Jack.WebApi.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("CheckHealthy")]
        public ActionResult CheckHealthy()
        {
            var machine = Environment.MachineName;
            return Content("OK," + $"machine:{machine}");
        }
    }
}
