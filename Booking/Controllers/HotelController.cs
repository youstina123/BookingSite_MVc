using Booking.ViewModel;
using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using System.Globalization;

namespace Booking.Controllers
{
    public class HotelController : Controller
    {
        ApplicationDbContext context;
        public HotelController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["hotellist"] = context.Hotels.ToList();

            return View("Search");
        }

        [HttpGet]
        public IActionResult HotelsofSpecificCity(string name)
        {
            ViewData["hotellist"] = context.Hotels.Where(h => h.City == name && h.IsDeleted == false).ToList();

            return View("Search");
        }
        [HttpPost]
        public IActionResult Search(SearchViewModel searchViewModel)
        {
            List<Hotel> hotels = new List<Hotel>();
            if (searchViewModel.Room == "Room")
            {
                hotels = context.Hotels.Include(r => r.rooms.Where(i => i.NumOfAdults <= searchViewModel.Customer && i.IsNormalRoom == true && i.IsDeleted == false)).ToList()
                    .Where(h => h.rooms.Count > 0 && h.City == searchViewModel.City && h.IsDeleted == false).ToList();

            }
            else if (searchViewModel.Room == "Suite")
            {
                hotels = context.Hotels.Include(r => r.rooms.Where(i => i.NumOfAdults <= searchViewModel.Customer && i.IsNormalRoom == false && i.IsDeleted == false)).ToList()
                    .Where(h => h.rooms.Count > 0 && h.City == searchViewModel.City && h.IsDeleted == false).ToList();

            }
            else
            {
                hotels = context.Hotels.Include(r => r.rooms.Where(i => i.NumOfAdults <= searchViewModel.Customer && i.IsDeleted == false)).ToList()
                    .Where(h => h.rooms.Count > 0 && h.City == searchViewModel.City && h.IsDeleted == false).ToList();
            }
            if (searchViewModel.CheckoutDate != null && searchViewModel.CheckoutDate != null)
            {
                var chin = searchViewModel.CheckinDate.ToString();
                var chout = searchViewModel.CheckoutDate.ToString();

                var date = DateTime.ParseExact(chin, "M/d/yyyy", CultureInfo.InvariantCulture);
                DateTime checkindate = Convert.ToDateTime(date.ToString("yyyy/MM/dd"));

                var dateout = DateTime.ParseExact(chout, "M/d/yyyy", CultureInfo.InvariantCulture);
                DateTime checkoutdate = Convert.ToDateTime(dateout.ToString("yyyy/MM/dd"));

                List<Hotel> avaliblehotel = new List<Hotel>();

                foreach (var hotel in hotels)
                {
                    int numberofrooms = hotel.rooms.Count;
                    foreach (var room in hotel.rooms)
                    {
                        bool isavalible = true;
                        for (DateTime startdate = checkindate; startdate <= checkoutdate; startdate = startdate.AddDays(1))
                        {
                            string date1 = Convert.ToString(context.bookingDates.Where(i => i.Date == startdate).Select(i => i.Id).FirstOrDefault());
                            bool datecheck = context.bookingChecks.Any(r => r.RoomId == room.Id && r.BookingDateId == date1);
                            if (datecheck)
                            {
                                isavalible = false;
                                startdate = checkoutdate.AddDays(1);
                                numberofrooms--;
                            }
                        }
                    }

                    if (numberofrooms <= hotel.rooms.Count && numberofrooms != 0) { avaliblehotel.Add(hotel); }
                }

                ViewData["hotels"] = avaliblehotel;
                return View(searchViewModel);
            }
            return RedirectToAction("Home", "Home");
        }
        [HttpPost]
        public IActionResult AdvancedSearch(SearchViewModel searchViewModel)
        {
            List<Hotel> hotels = new List<Hotel>();
            if (searchViewModel.Room == "Room")
            {
                hotels = context.Hotels.Include(r => r.rooms.Where(i => i.NumOfAdults <= searchViewModel.Customer && i.IsNormalRoom == true && i.IsDeleted == false)).ToList()
                    .Where(h => h.rooms.Count > 0 && h.City == searchViewModel.City && h.IsDeleted == false).ToList();

            }
            else if (searchViewModel.Room == "Suite")
            {
                hotels = context.Hotels.Include(r => r.rooms.Where(i => i.NumOfAdults <= searchViewModel.Customer && i.IsNormalRoom == false && i.IsDeleted == false)).ToList()
                    .Where(h => h.rooms.Count > 0 && h.City == searchViewModel.City && h.IsDeleted == false).ToList();

            }
            else
            {
                hotels = context.Hotels.Include(r => r.rooms.Where(i => i.NumOfAdults <= searchViewModel.Customer && i.IsDeleted == false)).ToList()
                    .Where(h => h.rooms.Count > 0 && h.City == searchViewModel.City && h.IsDeleted == false).ToList();
            }
            List<Hotel> avaliblehotel = new List<Hotel>();
            if (searchViewModel.CheckoutDate != null && searchViewModel.CheckoutDate != null)
            {
                var chin = searchViewModel.CheckinDate.ToString();
                var chout = searchViewModel.CheckoutDate.ToString();

                var date = DateTime.ParseExact(chin, "M/d/yyyy", CultureInfo.InvariantCulture);
                DateTime checkindate = Convert.ToDateTime(date.ToString("yyyy/MM/dd"));

                var dateout = DateTime.ParseExact(chout, "M/d/yyyy", CultureInfo.InvariantCulture);
                DateTime checkoutdate = Convert.ToDateTime(dateout.ToString("yyyy/MM/dd"));



                foreach (var hotel in hotels)
                {
                    int numberofrooms = hotel.rooms.Count;
                    foreach (var room in hotel.rooms)
                    {
                        bool isavalible = true;
                        for (DateTime startdate = checkindate; startdate <= checkoutdate; startdate = startdate.AddDays(1))
                        {
                            string date1 = Convert.ToString(context.bookingDates.Where(i => i.Date == startdate).Select(i => i.Id).FirstOrDefault());
                            bool datecheck = context.bookingChecks.Any(r => r.RoomId == room.Id && r.BookingDateId == date1);
                            if (datecheck)
                            {
                                isavalible = false;
                                startdate = checkoutdate.AddDays(1);
                                numberofrooms--;
                            }
                        }
                    }

                    if (numberofrooms <= hotel.rooms.Count && numberofrooms != 0) { avaliblehotel.Add(hotel); }
                }
                return PartialView("_AdvancedSearch", avaliblehotel);
            }


            return RedirectToAction("Home", "Home");
        }

        [HttpPost]
        public IActionResult FilterSearch(FiltersearchViewModel filtersearchViewModel)
        {
            List<int> hotelides = filtersearchViewModel.ides;
            List<int> starlist = filtersearchViewModel.stars;
            List<Hotel> hotelsfilter = new List<Hotel>();
            foreach (var hotelid in hotelides)
            {
                Hotel hotel = context.Hotels.FirstOrDefault(h => h.Id == hotelid);
                foreach (var star in starlist)
                {

                    if (Convert.ToInt32(hotel.Rate) == star)
                    {
                        hotelsfilter.Add(hotel);
                    }
                }
            }
            return PartialView("_AdvancedSearch", hotelsfilter);
        }
    }
}
