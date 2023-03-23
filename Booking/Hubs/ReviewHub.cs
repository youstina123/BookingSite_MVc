using BookingLibrary.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;

namespace Booking.Hubs
{
    public class ReviewHub : Hub
    {
        ApplicationDbContext Context = new ApplicationDbContext();
        public void NewComment(string Name, string Comment, int HotelID)
        {
            Customer customer = Context.Customers.Include(a => a.AppUser).FirstOrDefault(x => x.AppUser.UserName == Name);
            Clients.All.SendAsync("AddNewComment", Name, Comment, HotelID);//nameof Client method,data 
            Context.Reviews.Add(new Review { CustomerId = customer.AppUserId, Text = Comment, HotelId = HotelID });
            Context.SaveChanges();
        }
        public void NewRoomComment(string Name, string Comment, int HotelID, int Roomid)
        {
            Customer customer = Context.Customers.Include(a => a.AppUser).FirstOrDefault(x => x.AppUser.UserName == Name);
            Clients.All.SendAsync("AddNewComment", Name, Comment, HotelID, Roomid);//nameof Client method,data 
            Context.Reviews.Add(new Review { CustomerId = customer.AppUserId, Text = Comment, HotelId = HotelID, RoomId = Roomid });
            Context.SaveChanges();
        }
    }
}
