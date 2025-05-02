using ObiletDemo.API.Models;

namespace ObiletDemo.API.Services
{
    public interface ISystemService
    {
        SystemInfoResponse GetSystemInfo();
    }

    public class SystemService : ISystemService
    {
        public SystemInfoResponse GetSystemInfo()
        {
            return new SystemInfoResponse
            {
                ProjectName = "Obilet Demo API",
                Description = "A demo API project for Obilet",
                Architecture = "Microservices",
                Framework = ".NET 8.0",
                Technologies = new List<string> { "ASP.NET Core", "Docker", "Swagger" }
            };
        }
    }
} 