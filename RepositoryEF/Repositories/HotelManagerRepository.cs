using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.EF.Repository;

namespace RepositoryEF.Repositories
{
    public class HotelManagerRepository: BaseRepository<Hotel_Manager>, RepositoryModel.Interfaces.IHotelManagerReprository
    {
        ApplicationDbContext context;
        public HotelManagerRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public string FindMangerId(int hotelid)
        {
            string userid =context.Hotel_Managers.Where(m => m.HotelId == hotelid).Select(m => m.AppUserId).FirstOrDefault();
            return userid;
        }

        public Hotel_Manager FindMangerdetailes(string userid)
        {
            Hotel_Manager hotel_Manager = context.Hotel_Managers.Where(h =>h.AppUserId==userid).
                Include(h => h.Hotel).Include(a => a.AppUser).FirstOrDefault();
            return hotel_Manager;
        }





    }
}
