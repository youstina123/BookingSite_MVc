using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryModel.Models;
using RepositoryPatternWithUOW.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Repositories
{
    public class HotelRepository : BaseRepository<Hotel>, RepositoryModel.Interfaces.IHotelRepository
    {
        ApplicationDbContext context;
        public HotelRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public List<string> getphoto(int id)
        {

            List<string> photos = context.image.Where(e => e.HotelId == id).Select(e => e.Name).ToList();
            return photos;
        }
        public List<Review> getReviews(int id)
        {
            List<Review> reviews = context.Reviews.Where(i => i.IsDeleted == false && i.HotelId == id).OrderByDescending(d => d.Id).Take(8).Include(c => c.Customer).ThenInclude(a => a.AppUser).ToList();
            return reviews;
        }

        public List<Normal_Room> getrooms(int id)
        {

            List<Normal_Room> Rooms = new List<Normal_Room>();
            for (int i = 0; i < 4; i++)
            {
                Normal_Room room = context.normal_Rooms.Include(e => e.Room).ThenInclude(e => e.images).FirstOrDefault(e => e.Room.HotelId == id && ((int)e.Type_Of_Room) == i);
                if (room != null)
                {
                    Rooms.Add(room);
                }
            }
            return Rooms;
        }
        public Suit getsuit(int id)
        {

            return context.Suits.Include(e => e.Room).ThenInclude(e => e.images).FirstOrDefault(e => e.Room.HotelId == id);
        }
    }
}
