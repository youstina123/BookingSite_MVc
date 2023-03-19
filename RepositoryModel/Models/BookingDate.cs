using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Models
{
	public class BookingDate
	{
		[Key]
		public Guid Id { get; set; }

		[Column(TypeName = "date")]
		public DateTime Date { get; set; }
	}
}
