using ObiletDemo.Web.Models;

namespace ObiletDemo.Web.Services
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
                ProjectName = "Obilet Demo Web",
                Description = "Obilet Demo Uygulaması için geliştirilen Web projesi",
                Architecture = "MVC Architecture",
                Framework = ".NET 8.0",
                Technologies = new[] { "C#", "ASP.NET Core MVC", "Razor Pages", "Bootstrap" }
            };
        }
    }
}