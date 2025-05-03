namespace ObiletDemo.Web.Models
{
    public class SystemInfoResponse
    {
        public required string ProjectName { get; set; }
        public required string Description { get; set; }
        public required string Architecture { get; set; }
        public required string Framework { get; set; }
        public required List<string> Technologies { get; set; }
    }
}