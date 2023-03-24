using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Interfaces
{
    public interface IBookingDatesReprository:IBaseRepository<BookingDate>
    {
        string GetDateId(DateTime date);
    }
}
