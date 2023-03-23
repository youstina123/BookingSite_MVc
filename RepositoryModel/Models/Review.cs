using System.ComponentModel.DataAnnotations.Schema;

namespace BookingLibrary.Models
{
    public class Review
    {
        public int Id { get; set; }
		public string Text { get; set; }
		[ForeignKey("Hotel")]
        public int ?HotelId { get; set; }
        public Hotel ?Hotel { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public Customer ?Customer { get; set; }

        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public Room? Room { get; set; }
        public bool IsDeleted { get; set; }
    }
}
