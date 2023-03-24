using BookingLibrary.Models;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Interfaces
{
    public interface IBookingChecksReprository: IBaseRepository<BookingCheck>
    {
        bool DateCheck(Room room, string dateid);
    }
}
