using BookingLibrary.Models;
using RepositoryModel.Interfaces;
using RepositoryModel.Models;
using RepositoryPatternWithUOW.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Repositories
{
    public class BookingDatesReprository : BaseRepository<BookingDate>, IBookingDatesReprository
    {
        ApplicationDbContext context;
        public BookingDatesReprository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public string GetDateId(DateTime date)
        {
            string dateid = Convert.ToString(context.bookingDates.Where(i => i.Date == date).Select(i => i.Id).FirstOrDefault());
            return dateid;
        }
    }
}
