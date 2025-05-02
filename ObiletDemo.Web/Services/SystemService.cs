using ObiletDemo.Web.Models;
using System.Runtime.InteropServices;

namespace ObiletDemo.Web.Services
{
    public class SystemService : ISystemService
    {
        public SystemInfoResponse GetSystemInfo()
        {
            return new SystemInfoResponse
            {
                ProjectName = "Obilet Demo App",
                Description = "A demo application for Obilet",
                Architecture = RuntimeInformation.OSArchitecture.ToString(),
                Framework = "ASP.NET Core 8.0",
                Technologies = new List<string> { "C#", "ASP.NET Core", "Docker" }
            };
        }
    }
}