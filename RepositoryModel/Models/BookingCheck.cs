using BookingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Models
{
	public class BookingCheck
	{


		public int RoomId { get; set; }
		public Room? Room { get; set; }


		public string BookingDateId { get; set; }
		public BookingDate? BookingDate { get; set; }
	}
}
