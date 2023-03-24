using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Models;
using RepositoryPatternWithUOW.Core.Repository;

namespace Booking.Controllers
{
    public class HotelDetailsController : Controller
    {
        AppUser userModel = new AppUser();
        ApplicationDbContext context = new ApplicationDbContext();
        IUnitOfWorkRepository unitOfWorkRepository;

        public HotelDetailsController(IUnitOfWorkRepository unitOfWorkRepository)
        {
            this.unitOfWorkRepository = unitOfWorkRepository;
            //   this.hotelRepository = hotelRepository;

        }

        //kermena

        public async Task<IActionResult>  getPhotos(int id)
        {
            Hotel hotel = await unitOfWorkRepository.Hotels.FindAsync(e => e.Id == id);
            List<string> photos = unitOfWorkRepository.hotels.getphoto(id);
            List<Review> reviews = unitOfWorkRepository.hotels.getReviews(id);

            //List<Normal_Room> Rooms = new List<Normal_Room>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Normal_Room room = context.normal_Rooms.Include(e => e.Room).ThenInclude(e => e.images).FirstOrDefault(e => e.Room.HotelId == id && ((int)e.Type_Of_Room) == i);
            //    if (room != null)
            //    {
            //        Rooms.Add(room);
            //    }
            //}
            Suit suit = unitOfWorkRepository.hotels.getsuit(id);

            string userName = "";
            if (User.Identity.IsAuthenticated)
            {
                userName = User.Identity.Name.ToString();
                ViewData["User"] = userName;
            }

            ViewData["Reviews"] = reviews;
            ViewData["photo"] = photos;
            ViewData["normal"] = unitOfWorkRepository.hotels.getrooms(id);
            ViewData["Suit"] = suit;


            return View(hotel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
