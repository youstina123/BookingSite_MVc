using RepositoryModel.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingLibrary.Models
{
    
    public class Room
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Room_Num { get; set; }
        
        [Unique]
        public int NumOfAdults { get; set; }
        public double Cost_Per_Night { get; set; }

        public bool ISavailable { get; set; }
       
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public Hotel ?Hotel { get; set; }
		List<Booking>? bookings { get; set; }
		public bool IsNormalRoom { get; set; }

		public bool IsDeleted { get; set; }
		public List<image>? images { get; set; }


	}
}