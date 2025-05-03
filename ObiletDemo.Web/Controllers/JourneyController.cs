using Microsoft.AspNetCore.Mvc;
using ObiletDemo.Web.Models;

namespace ObiletDemo.Web.Controllers
{
    public class JourneyController : Controller
    {
        public IActionResult Index()
        {
            var model = new JourneySearchModel
            {
                DepartureDate = DateTime.Today
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Search(JourneySearchModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return RedirectToAction("List", new { 
                origin = model.OriginLocation, 
                destination = model.DestinationLocation, 
                date = model.DepartureDate.ToString("yyyy-MM-dd") 
            });
        }

        public IActionResult List(string origin, string destination, string date)
        {
            var searchModel = new JourneySearchModel
            {
                OriginLocation = origin,
                DestinationLocation = destination,
                DepartureDate = DateTime.Parse(date)
            };

            var journeys = new List<Journey>
            {
                new Journey { DepartureTime = "08:00", ArrivalTime = "12:00", Duration = "4h 0m", Price = 150.00m, BusOperator = "Metro Turizm", BusType = "2+1" },
                new Journey { DepartureTime = "09:30", ArrivalTime = "13:30", Duration = "4h 0m", Price = 160.00m, BusOperator = "Kamil Koç", BusType = "2+1" },
                new Journey { DepartureTime = "10:00", ArrivalTime = "14:00", Duration = "4h 0m", Price = 145.00m, BusOperator = "Pamukkale", BusType = "2+1" },
                new Journey { DepartureTime = "11:00", ArrivalTime = "15:00", Duration = "4h 0m", Price = 155.00m, BusOperator = "Varan", BusType = "2+1" },
                new Journey { DepartureTime = "12:30", ArrivalTime = "16:30", Duration = "4h 0m", Price = 165.00m, BusOperator = "Ulusoy", BusType = "2+1" },
                new Journey { DepartureTime = "14:00", ArrivalTime = "18:00", Duration = "4h 0m", Price = 140.00m, BusOperator = "Metro Turizm", BusType = "2+1" },
                new Journey { DepartureTime = "15:30", ArrivalTime = "19:30", Duration = "4h 0m", Price = 170.00m, BusOperator = "Kamil Koç", BusType = "2+1" },
                new Journey { DepartureTime = "17:00", ArrivalTime = "21:00", Duration = "4h 0m", Price = 150.00m, BusOperator = "Pamukkale", BusType = "2+1" },
                new Journey { DepartureTime = "18:30", ArrivalTime = "22:30", Duration = "4h 0m", Price = 160.00m, BusOperator = "Varan", BusType = "2+1" },
                new Journey { DepartureTime = "20:00", ArrivalTime = "00:00", Duration = "4h 0m", Price = 155.00m, BusOperator = "Ulusoy", BusType = "2+1" }
            };

            var viewModel = new JourneyListViewModel
            {
                SearchModel = searchModel,
                Journeys = journeys
            };

            return View(viewModel);
        }
    }
} 