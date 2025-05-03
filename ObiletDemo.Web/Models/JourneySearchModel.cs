using System.ComponentModel.DataAnnotations;

namespace ObiletDemo.Web.Models
{
    public class JourneySearchModel
    {
        [Required(ErrorMessage = "Origin location is required")]
        public string OriginLocation { get; set; }

        [Required(ErrorMessage = "Destination location is required")]
        public string DestinationLocation { get; set; }

        [Required(ErrorMessage = "Departure date is required")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }
    }
} 