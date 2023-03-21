using Booking.ViewModel;
using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Models;
using RepositoryPatternWithUOW.Core.Repository;

namespace Booking.Controllers
{
    public class HotelMangerController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
       
            
        IUnitOfWorkRepository unitOfWorkRepository;
        public IActionResult HotelRooms()
        {
            List<Normal_Room> rooms = context.normal_Rooms.Where(r => r.Room.IsNormalRoom == true && r.Room.IsDeleted==false)
                .Include(r=>r.Room).Include(r=>r.Room.images).ToList();
                

            return View(rooms);
        }

        public IActionResult HotelSuits()
        {
            List<Suit> suits = context.Suits.Include(r => r.Room).Include(r=>r.Room.images).
                Where(r => r.Room.IsNormalRoom == false && r.IsDeleted==false).ToList();


            return View(suits);
        }

        [HttpPost]
        public IActionResult AddRoom(NormalRoomViewModel normal_Room)
        {
            string nameM= User.Identity.Name.ToString();

            int id = context.Hotel_Managers.Include(h => h.AppUser).Where(a => a.AppUser.UserName == nameM).Select(a => a.HotelId).FirstOrDefault().Value;

            Room room = new Room();

            room.HotelId= id;
            room.NumOfAdults = normal_Room.NumOfAdults;
            room.Room_Num = normal_Room.Room_Num;
            room.Cost_Per_Night = normal_Room.Cost_Per_Night;
            room.Description = normal_Room.Description;
            room.ISavailable = true;
            room.IsNormalRoom = true;

            context.Rooms.Add(room);
            context.SaveChanges();

            Normal_Room nRoom = new Normal_Room();
            int idRoom = context.Rooms.Where(r => r.Room_Num == normal_Room.Room_Num && r.HotelId == id).Select(r => r.Id).FirstOrDefault();

            nRoom.RoomId = idRoom;
            switch (normal_Room.Type_Of_Room.ToString())
            {
                case "Single": { nRoom.Type_Of_Room = Type_Of_Room.Single; break; }

                case "Double": { nRoom.Type_Of_Room = Type_Of_Room.Double; break; }

                case "Triple": { nRoom.Type_Of_Room = Type_Of_Room.Triple; break; }

                case "Fourth": { nRoom.Type_Of_Room = Type_Of_Room.Fourth; break; }

            }
            context.normal_Rooms.Add(nRoom);
            context.SaveChanges();

            foreach (var RoomImage in normal_Room.image)
            {
                image image = new image();
                image.Name = RoomImage;
                image.RoomId = idRoom;
                context.Add(image);
                context.SaveChanges();
            }

            return RedirectToAction("HotelRooms");
        }

        [HttpGet]
        public IActionResult AddRoom()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRoom(int id)
        {
           // Normal_Room normal_Room = unitOfWorkRepository.NnormalRooms.Find(r => r.RoomId == id, new[] {"Room"});

            Normal_Room normal_Room = context.normal_Rooms.Include(r=>r.Room).FirstOrDefault(r => r.RoomId==id);
            return View(normal_Room);
        }

        [HttpPost]
        public IActionResult UpdateRoom(Normal_Room normal_Room, int id)
        {
            //Normal_Room oldRoom = unitOfWorkRepository.NnormalRooms.Find(r => r.RoomId == id, new[] { "Room" });

            Normal_Room oldRoom = context.normal_Rooms.Include(r => r.Room).FirstOrDefault(r => r.RoomId == id);



            oldRoom.Room.Room_Num = normal_Room.Room.Room_Num;
            oldRoom.Room.Description = normal_Room.Room.Description;
            oldRoom.Room.NumOfAdults = normal_Room.Room.NumOfAdults;
            oldRoom.Room.Cost_Per_Night = normal_Room.Room.Cost_Per_Night;

            switch (normal_Room.Type_Of_Room.ToString())
            {
                case "Single": { oldRoom.Type_Of_Room = Type_Of_Room.Single; break; }

                case "Double": { oldRoom.Type_Of_Room = Type_Of_Room.Double; break; }

                case "Triple": { oldRoom.Type_Of_Room = Type_Of_Room.Triple; break; }

                case "Fourth": { oldRoom.Type_Of_Room = Type_Of_Room.Fourth; break; }

            }

            normal_Room.Room.ISavailable = true;
            normal_Room.Room.IsDeleted = false;
           // unitOfWorkRepository.NnormalRooms.Update(normal_Room);
            context.SaveChanges();
            return RedirectToAction("HotelRooms");
        }

        public IActionResult DeleteRoom(int id) 
        {
            Room room = context.Rooms.FirstOrDefault(r => r.Id == id);
            room.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction("HotelRooms");

        }

        [HttpPost]
        public IActionResult AddSuit(SuitViewModel Rooms)
        {
            string nameM = User.Identity.Name.ToString();
            int id = context.Hotel_Managers.Include(h => h.AppUser).Where(a => a.AppUser.UserName == nameM).Select(a => a.HotelId).FirstOrDefault().Value;

         
			Room room = new Room();

			room.HotelId = id;
			room.NumOfAdults = Rooms.NumOfAdults;
			room.Room_Num = Rooms.Room_Num;
			room.Cost_Per_Night = Rooms.Cost_Per_Night;
			room.Description = Rooms.Description;

			//room.images = Rooms.images;
			room.ISavailable = true;
			room.IsNormalRoom = false;
			context.Rooms.Add(room);
			context.SaveChanges();

			Suit AddSuit = new Suit();
			int RoomID = context.Rooms.Where(R => R.Room_Num == Rooms.Room_Num && R.HotelId == id).Select(r => r.Id).FirstOrDefault();

            AddSuit.RoomId = RoomID;
            AddSuit.Num_Of_Rooms = Rooms.Num_Of_Rooms;
			context.Suits.Add(AddSuit);
            context.SaveChanges();

            foreach (var RoomImage in Rooms.image)
            {
                image image = new image();
                image.Name = RoomImage;
                image.RoomId = RoomID;
                context.Add(image);
                context.SaveChanges();
            }

            return RedirectToAction("HotelSuits");
        }

        [HttpGet]
        public IActionResult AddSuit()
        {

            
            return View();
        }
        [HttpGet]
        public IActionResult Updatesuits(int id)
        {

            Suit suit = context.Suits.Include(s => s.Room).FirstOrDefault(s => s.RoomId == id);
            return View(suit);
        }
       

        [HttpPost]
        public IActionResult Updatesuits(Suit suit, int id)
        {
            Suit oldSuit = context.Suits.Include(s => s.Room).FirstOrDefault(s => s.RoomId == id);

            oldSuit.Room.Room_Num = suit.Room.Room_Num;
            oldSuit.Room.Description = suit.Room.Description;
            oldSuit.Room.NumOfAdults = suit.Room.NumOfAdults;
            oldSuit.Room.Cost_Per_Night = suit.Room.Cost_Per_Night;
            oldSuit.Num_Of_Rooms = suit.Num_Of_Rooms;
            oldSuit.IsDeleted = false;
            oldSuit.Room.IsNormalRoom = false;

            context.SaveChanges();

            return RedirectToAction("HotelSuits");
        }

       

        public IActionResult DeleteSuit(int id)
        {
            Suit suit = context.Suits.FirstOrDefault(s => s.RoomId == id);
            suit.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction("HotelSuits");

        }
    }
}
