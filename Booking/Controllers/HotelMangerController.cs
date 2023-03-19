using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Models;

namespace Booking.Controllers
{
    public class HotelMangerController : Controller
    {
        ApplicationDbContext context =new ApplicationDbContext();

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
        public IActionResult AddRoom(Normal_Room normal_Room)
        {
            string nameM= User.Identity.Name.ToString();

            int id = context.Hotel_Managers.Include(h => h.AppUser).Where(a => a.AppUser.UserName == nameM).Select(a => a.HotelId).FirstOrDefault().Value;
            Normal_Room nRoom = new Normal_Room();

            Room room = new Room();
            room.HotelId= id;
            room.NumOfAdults = normal_Room.Room.NumOfAdults;
            room.Room_Num = normal_Room.Room.Room_Num;
            room.Cost_Per_Night = normal_Room.Room.Cost_Per_Night;
            room.Description = normal_Room.Room.Description;
            

            switch (normal_Room.Type_Of_Room.ToString())
            {
                case "Single": { normal_Room.Type_Of_Room = Type_Of_Room.Single; break; }

                case "Double": { normal_Room.Type_Of_Room = Type_Of_Room.Double; break; }

                case "Triple": { normal_Room.Type_Of_Room = Type_Of_Room.Triple; break; }

                case "Fourth": { normal_Room.Type_Of_Room = Type_Of_Room.Fourth; break; }

            }

            room.images = normal_Room.Room.images;
            room.ISavailable = true;
            room.IsNormalRoom = true;
            context.Rooms.Add(room);
            context.SaveChanges();


            int idRoom = context.Rooms.Where(r => r.Room_Num == normal_Room.Room.Room_Num).Select(r => r.Id).FirstOrDefault();
            nRoom.RoomId = idRoom;
            context.normal_Rooms.Add(nRoom);
            context.SaveChanges();
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
            Normal_Room normal_Room = context.normal_Rooms.Include(r=>r.Room).FirstOrDefault(r => r.RoomId==id);
            return View(normal_Room);
        }

        [HttpPost]
        public IActionResult UpdateRoom(Normal_Room normal_Room, int id)
        {
            Normal_Room oldRoom = context.normal_Rooms.Include(r=>r.Room).FirstOrDefault(r => r.RoomId == id);

          

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

            oldRoom.Room.ISavailable = true;
            oldRoom.Room.IsDeleted = false;
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
        public IActionResult AddSuit(Suit suit)
        {
            string nameM = User.Identity.Name.ToString();
            int id = context.Hotel_Managers.Include(h => h.AppUser).Where(a => a.AppUser.UserName == nameM).Select(a => a.HotelId).FirstOrDefault().Value;

            Suit AddSuit = new Suit();

            AddSuit.Room.NumOfAdults = suit.Room.NumOfAdults;
            AddSuit.Room.Room_Num = suit.Room.Room_Num;
            AddSuit.Room.Cost_Per_Night = suit.Room.Cost_Per_Night;
            AddSuit.Room.Description = suit.Room.Description;
            foreach (var item in AddSuit.Room.images)
            {
                item.Name = suit.Room.images.ToString();

            }
            AddSuit.Room.ISavailable = true;
            AddSuit.Room.IsNormalRoom = false;
            AddSuit.Num_Of_Rooms = suit.Num_Of_Rooms;

            context.Suits.Add(AddSuit);
            context.SaveChanges();


            AddSuit.Room.HotelId = id;
            context.SaveChanges();
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
