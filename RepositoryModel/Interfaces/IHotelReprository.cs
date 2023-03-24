using BookingLibrary.Models;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Interfaces
{
    public interface IHotelRepository : IBaseRepository<Hotel>
    {
        List<string> getphoto(int id);
        List<Review> getReviews(int id);
        List<Normal_Room> getrooms(int id);
        Suit getsuit(int id);
        List<Hotel> Orderbycity();
        List<Hotel> GetHotelsbaseRoom(bool? IsRoom, int Customer, string city);
    }
}
