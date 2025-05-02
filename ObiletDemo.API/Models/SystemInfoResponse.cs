namespace ObiletDemo.API.Models
{
    public class SystemInfoResponse
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Architecture { get; set; }
        public string Framework { get; set; }
        public string[] Technologies { get; set; }
    }
} 