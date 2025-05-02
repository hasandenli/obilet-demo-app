using Microsoft.AspNetCore.Mvc;
using ObiletDemo.API.Models;
using ObiletDemo.API.Services;

namespace ObiletDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemController : ControllerBase
    {
        private readonly ISystemService _systemService;

        public SystemController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        [HttpGet("info")]
        public ActionResult<SystemInfoResponse> GetSystemInfo()
        {
            var systemInfo = _systemService.GetSystemInfo();
            return Ok(systemInfo);
        }
    }
} 