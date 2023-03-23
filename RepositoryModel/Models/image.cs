    using System.ComponentModel.DataAnnotations.Schema;

namespace BookingLibrary.Models
{
    public class image
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public byte[]? Image;

        [ForeignKey("Hotel")]
        public int? HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public Room? Room { get; set; }
        public bool IsDeleted { get; set; }
    }
}