using Microsoft.AspNetCore.Mvc;
using ObiletDemo.Web.Models;
using ObiletDemo.Web.Services;

namespace ObiletDemo.Web.Controllers
{
    public class SystemController : Controller
    {
        private readonly ISystemService _systemService;

        public SystemController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        public IActionResult Info()
        {
            var systemInfo = _systemService.GetSystemInfo();
            return View(systemInfo);
        }
    }
}