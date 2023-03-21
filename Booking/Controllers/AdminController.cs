using Booking.ViewModel;
using BookingLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryPatternWithUOW.Core.Repository;

namespace Booking.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly IUnitOfWorkRepository unitOfWorkRepository;
        ApplicationDbContext context = new ApplicationDbContext();
        UserManager<AppUser> userManager;

        public AdminController(UserManager<AppUser> userManager, IUnitOfWorkRepository unitOfWorkRepository)
        {
            this.userManager = userManager;
            this.unitOfWorkRepository = unitOfWorkRepository;
        }
        

        public IActionResult AdminNotifications()
        {
            MessageDetailViewModel message; 
            List<MessageDetailViewModel> messagesList = new List<MessageDetailViewModel>();


          

            List<Hotel> hotel = context.Hotels.Where(h=>h.IsConfermed==false).ToList();

            List<string> hotelMangersIds = new List<string>();

            foreach(var item in hotel)
            {

            string appUserId = context.Hotel_Managers.Where(m=>m.HotelId==item.Id).Select(m=>m.AppUserId).FirstOrDefault();
                hotelMangersIds.Add(appUserId);
            }
             List<AppUser> hotelManger=new List<AppUser>();

            foreach(var item in hotelMangersIds)
            {
                //AppUser hotelM = unitOfWorkRepository.AppUsers.GetByIDString(item);
				AppUser hotelM = context.AppUsers.FirstOrDefault(m => m.Id == item);
				hotelManger.Add(hotelM);
            }

            foreach (var item in hotelManger)
            {  
                message = new MessageDetailViewModel();
                message.HotelManagerName = item.UserName;
                message.PhoneNumber = item.PhoneNumber;
                message.Email = item.Email;
                message.Gender = item.gender.ToString();
                message.Id = item.Id;
                messagesList.Add(message);

            }
            foreach (var item in hotel)
            {
                message= new MessageDetailViewModel();
                message.HotelName = item.Name;
                message.HotelCountry = item.Country;
                message.HotelCity = item.City;
                message.HotelStreet = item.Street;
                message.HotelDescription = item.Description.ToString();
                message.Rate = item.Rate.ToString();


                
           }
            ViewBag.Model = messagesList;
            return View();
        }

        public IActionResult HotelManagerMessageDetais(string id)
        {
            MessageDetailViewModel message = new MessageDetailViewModel();

            string i = id;
            //Hotel hotel = context.Hotel_Managers.Include(m=>m.Hotel).ThenInclude(m=>m.Hotel_Manager.AppUser)
            //    .FirstOrDefault(h => h.Id == id && h.Hotel_Manager.HotelId==id && h.Hotel_Manager.AppUserId==h.Hotel_Manager.AppUser.Id);

            Hotel_Manager hotel = context.Hotel_Managers.Where(h=>h.AppUserId==id ).
                Include(h => h.Hotel).Include(a => a.AppUser).FirstOrDefault();
            message.Id = hotel.AppUser.Id;
            message.HotelManagerName = hotel.AppUser.UserName;
            message.Gender = hotel.AppUser.gender.ToString();
            message.Email = hotel.AppUser.Email;
            message.PhoneNumber = hotel.AppUser.PhoneNumber;

            message.HotelName = hotel.Hotel.Name;
            message.HotelCountry= hotel.Hotel.Country;
            message.HotelCity= hotel.Hotel.City;
            message.HotelStreet=hotel.Hotel.Street;
            message.HotelDescription= hotel.Hotel.Description;
            message.Rate= hotel.Hotel.Rate.ToString();

            return PartialView("_HotelManagerMessageDetais", message);
        }

        public IActionResult AdminHotels()
        {
            List<Hotel> hotelList = context.Hotels.Where(h=>h.IsDeleted==false).Include(h=>h.Images).ToList();
            return View(hotelList);
        }

        public IActionResult DeleteHotel(int id) {

            Hotel hotel =context.Hotels.FirstOrDefault(h=>h.Id==id);
            hotel.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction( "AdminHotels");
        }

        [HttpGet]
        public IActionResult UpdateHotel(int id)
        {
            Hotel hotel=unitOfWorkRepository.Hotels.GetByID(id);
           // Hotel hotel = context.Hotels.FirstOrDefault(h=>h.Id==id);
            
            return View(hotel) ;
        }
           [HttpPost]
        public IActionResult UpdateHotel(Hotel newHotel,int id)
        {
            //Hotel hotel = context.Hotels.FirstOrDefault(h => h.Id == id);

			Hotel hotel = unitOfWorkRepository.Hotels.GetByID(id);
          
            //hotel.Name = newHotel.Name;
            //hotel.Street = newHotel.Street;
            //hotel.Country = newHotel.Country;
            //hotel.City = newHotel.City;
            //hotel.Description = newHotel.Description;
            //hotel.Rate = newHotel.Rate;
            unitOfWorkRepository.Hotels.Update(newHotel);
			//context.SaveChanges();
			return RedirectToAction("AdminHotels");
        }
        [HttpGet]
        public async Task<IActionResult> HotelManagerRoleConfirmation(string id)
        {


            AppUser hotel_Manager = context.AppUsers.FirstOrDefault(h => h.Id == id); 

          await userManager.AddToRoleAsync(hotel_Manager,"HotelManger");
            return RedirectToAction("AdminNotifications");
            
        }

        public IActionResult AdminProfit()
        {
            return View();
        }



    }
}
