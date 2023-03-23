using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryModel.Interfaces;
using RepositoryPatternWithUOW.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomReopository 
    {
        ApplicationDbContext context;
        public RoomRepository(ApplicationDbContext _context):base(_context)
        {
            this.context = _context;
        }
        public List<Room> GetllRooms(int id)
        {
            return context.Rooms
                .Include(r => r.Hotel)
                .Include(r => r.reviews)
                .Include(r => r.images)
                .Where(r => r.HotelId == id).ToList();
        }
       
        public List<Room> GetRelativeRooms(int id)
        {

            Room room = GetRoomByID(id);
            if (room.IsNormalRoom)
            {
                List<Room> rooms = context.Rooms.Include(r => r.images).Include(r => r.Normal_Room).Where(r => r.Cost_Per_Night >= room.Cost_Per_Night && r.Normal_Room.Type_Of_Room == room.Normal_Room.Type_Of_Room).ToList();
                if (rooms.Count > 0)
                {
                    return rooms;
                }
                else
                {
                    return context.Rooms
                                .Include(r => r.images)
                                .Include(r => r.Normal_Room)
                                .Where(r => r.Normal_Room.Type_Of_Room == room.Normal_Room.Type_Of_Room).ToList();
                }
            }
            else
            {
                List<Room> rooms = context.Rooms
                                    .Include(r => r.images)
                                    .Include(r => r.Suit)
                                    .Where(r => r.Cost_Per_Night >= room.Cost_Per_Night && r.Suit.Num_Of_Rooms >= room.Suit.Num_Of_Rooms).ToList();
                if (rooms.Count > 0)
                {
                    return rooms;
                }
                else
                {
                    return context.Rooms
                                    .Include(r => r.images)
                                    .Include(r => r.Suit)
                                    .Where(r => r.Suit.Num_Of_Rooms >= room.Suit.Num_Of_Rooms).ToList();
                }
            }

        }

        public Room GetRoomByID(int id)
        {
            Room room = context.Rooms.
               Include(r => r.Hotel).
               Include(r => r.Normal_Room).
               Include(r => r.Suit).
               Include(r => r.images).
               Include(r => r.reviews).
               ThenInclude(rev => rev.Customer).
               ThenInclude(c => c.AppUser).
               FirstOrDefault(r => r.Id == id);
            return room;
        }
       
    }
}

//public void Insert(Room room)
//{
//    context.Rooms.Add(room);
//    context.SaveChanges();

//}

//public void Update(int id, Room room)
//{
//    Room Orgroom = context.Rooms.
//   Include(r => r.Hotel).
//   Include(r => r.Normal_Room).
//   Include(r => r.Suit).
//   Include(r => r.images).
//   FirstOrDefault(r => r.Id == id);
//    if (Orgroom.IsNormalRoom)
//    {
//        Orgroom.IsNormalRoom = true;
//        Orgroom.Normal_Room.Type_Of_Room = room.Normal_Room.Type_Of_Room;
//        Orgroom.images = room.images;
//        Orgroom.ISavailable = room.ISavailable;
//        Orgroom.IsDeleted = room.IsDeleted;

//    }
//}