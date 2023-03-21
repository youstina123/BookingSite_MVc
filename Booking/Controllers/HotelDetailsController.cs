using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Models;

namespace Booking.Controllers
{
	public class HotelDetailsController : Controller
	{
		AppUser userModel = new AppUser();
		ApplicationDbContext context = new ApplicationDbContext();


		//kermena

		public IActionResult getPhotos()
		{
            Hotel hotel = context.Hotels.Where(e => e.Id == 1).FirstOrDefault();
            List<string> photos = context.image.Where(e => e.HotelId == 1).Select(e => e.Name).ToList();
            List<Review> reviews = context.Reviews.Where(i => i.IsDeleted == false).OrderByDescending(d => d.Id).Take(6).Include(c => c.Customer).ThenInclude(a => a.AppUser).ToList();

            List<Normal_Room> Rooms = new List<Normal_Room>();
            for (int i = 0; i < 4; i++)
            {
                Normal_Room room = context.normal_Rooms.Include(e => e.Room).ThenInclude(e => e.images).FirstOrDefault(e => e.Room.HotelId == 1 && ((int)e.Type_Of_Room) == i);
                if (room != null)
                {
                    Rooms.Add(room);
                }
            }
            Suit suit = context.Suits.Include(e => e.Room).ThenInclude(e => e.images).FirstOrDefault(e => e.Room.HotelId == 1);

            string userName = "";
            if (User.Identity.IsAuthenticated)
            {
                userName = User.Identity.Name.ToString();
                ViewData["User"] = userName;
            }

            ViewData["Reviews"] = reviews;
            ViewData["photo"] = photos;
            ViewData["normal"] = Rooms;
            ViewData["Suit"] = suit;


            return View(hotel);
        }
		public IActionResult Index()
		{
			return View();
		}
	}
}
