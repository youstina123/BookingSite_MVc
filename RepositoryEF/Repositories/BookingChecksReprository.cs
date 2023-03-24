using BookingLibrary.Models;
using RepositoryModel.Interfaces;
using RepositoryModel.Models;
using RepositoryPatternWithUOW.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RepositoryEF.Repositories
{
    public class BookingChecksReprository : BaseRepository<BookingCheck>, IBookingChecksReprository
    {
        ApplicationDbContext context;
        public BookingChecksReprository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public bool DateCheck(Room room,string dateid)
        {
            bool datecheck = context.bookingChecks.Any(r => r.RoomId == room.Id && r.BookingDateId == dateid);
            return datecheck;
        }
    }
}
