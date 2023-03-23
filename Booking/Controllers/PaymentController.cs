using Booking.ViewModel;
using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.Repository;

namespace Booking.Controllers
{
	public class PaymentController : Controller
	{
		IUnitOfWorkRepository unitOfWorkRepository;

		public PaymentController(IUnitOfWorkRepository unitOfWorkRepository)
		{
			this.unitOfWorkRepository = unitOfWorkRepository;
		}
		public async Task<IActionResult> Index(int Id,double profit)
		{
			BookingPay booking = new BookingPay();
            string nameM = User.Identity.Name.ToString();
			AppUser custmer= await unitOfWorkRepository.AppUsers.FindAsync(c=>c.UserName== nameM);
            Room room = unitOfWorkRepository.Rooms.Find(r => r.Id == Id, new[] { "Hotel" });
			string name=room.Hotel.Name;
			booking.totalPrice = profit;
			booking.RoomId=room.Id;
			booking.HotelId = room.HotelId;
			booking.CustomerId = custmer.Id;
			unitOfWorkRepository.BookingPays.Add(booking);
			return View();
		}

		[HttpGet]
		public IActionResult PaymentDetails(int id,int days)

		{
			PaymentViewModel paymentView= new PaymentViewModel();
			Room room=unitOfWorkRepository.Rooms.GetByID(id);

			double price= room.Cost_Per_Night *days;
			paymentView.Price = price;
			paymentView.Id = room.Id;
			return View(paymentView);
		}



		[HttpPost]
        public IActionResult PaymentDetails(PaymentViewModel payment)

        {
           // PaymentViewModel paymentView = new PaymentViewModel();
           //// Room room = unitOfWorkRepository.Rooms.GetByID(id);

           // paymentView.Price = room.Cost_Per_Night;
            return View();
        }
    }
}
