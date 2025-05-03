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

            // TODO: Implement actual journey search logic
            return RedirectToAction("List", new { 
                origin = model.OriginLocation, 
                destination = model.DestinationLocation, 
                date = model.DepartureDate.ToString("yyyy-MM-dd") 
            });
        }

        public IActionResult List(string origin, string destination, string date)
        {
            // TODO: Implement journey list view
            return View();
        }
    }
} 