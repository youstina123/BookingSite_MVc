using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookingLibrary.Models;

namespace RepositoryModel.Interfaces
{
    public interface IHotelManagerReprository:IBaseRepository<Hotel_Manager>
    {
        string FindMangerId(int hotelid);
        public Hotel_Manager FindMangerdetailes(string userid);
    }
}
