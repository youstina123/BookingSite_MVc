using BookingLibrary.Models;
using RepositoryModel.Models;

namespace Booking.ViewModel
{
    public class NormalRoomViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Room_Num { get; set; }
        public int NumOfAdults { get; set; }
        public double Cost_Per_Night { get; set; }
        public bool ISavailable { get; set; }
        public int HotelId { get; set; }
        public bool IsNormalRoom { get; set; }
        public int RoomId { get; set; }
        public Type_Of_Room Type_Of_Room { get; set; }
        public List<string> image { get; set; } 
    }
}
