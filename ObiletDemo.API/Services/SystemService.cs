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
                Description = "Obilet Demo Uygulaması için geliştirilen API projesi",
                Architecture = "Clean Architecture",
                Framework = ".NET 8.0",
                Technologies = new[] { "C#", "ASP.NET Core", "Entity Framework Core", "Swagger" }
            };
        }
    }
} 