using Microsoft.Build.Framework;

namespace Booking.ViewModel
{
    public class PaymentViewModel
    {
      
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string CarNumber { get; set; }
       
        [Required]
        public string State { get; set; }
       
        [Required]
        public string City { get; set; }
       
        [Required]
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public double Price { get; set; }
    }
}
