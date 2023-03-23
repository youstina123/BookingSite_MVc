using Booking.Models;
using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using RepositoryEF;
using System.Diagnostics;

namespace Booking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationDbContext context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            string repedcity = "";
            List<string> cities = new List<string>();
            List<Hotel> hotels = context.Hotels.OrderBy(h => h.City).ToList();
            foreach (Hotel hotel in hotels)
            {
                if (hotel.City != repedcity)
                {
                    cities.Add(hotel.City);
                }
                repedcity = hotel.City;
            }
            ViewData["Cities"] = cities.ToList();
            return View(hotels);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUS()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}