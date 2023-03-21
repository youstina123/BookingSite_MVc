using BookingLibrary.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.ViewModel
{
	public class SuitViewModel
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int Room_Num { get; set; }

		// [Unique]
		public int NumOfAdults { get; set; }
		public double Cost_Per_Night { get; set; }

		public bool ISavailable { get; set; }
		public int HotelId { get; set; }
		public bool IsNormalRoom { get; set; }
        public List<string> image { get; set; }
        public int RoomId { get; set; }
		public int Num_Of_Rooms { get; set; }

	}
}
