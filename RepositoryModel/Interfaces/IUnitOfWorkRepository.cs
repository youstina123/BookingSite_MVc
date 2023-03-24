using BookingLibrary.Models;
using RepositoryModel.Interfaces;
using RepositoryModel.Models;

namespace RepositoryPatternWithUOW.Core.Repository
{
    public interface IUnitOfWorkRepository: IDisposable
    {
        //IBaseRepository<UnitOfWork> BaseRepository { get; }
       IBaseRepository<AppUser> AppUsers { get; }
       // IBaseRepository<Hotel> Hotels { get; }
        IBookingDatesReprository BookingDates { get; }
        IBookingChecksReprository BookingChecks { get; }
        IBaseRepository<BookingPay> BookingPays { get; }
        IBaseRepository<Room> Room { get; }

        IBaseRepository<Customer> Customers { get; }
        IHotelManagerReprository HotelManagers { get; }
        IRoomReopository Rooms { get; }
        IHotelRepository Hotels { get; }
        void Complete();
    }
}
