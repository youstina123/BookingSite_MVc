using BookingLibrary.Models;
using RepositoryModel.Interfaces;
using RepositoryModel.Models;

namespace RepositoryPatternWithUOW.Core.Repository
{
    public interface IUnitOfWorkRepository: IDisposable
    {
        //IBaseRepository<UnitOfWork> BaseRepository { get; }
       IBaseRepository<AppUser> AppUsers { get; }
        IBaseRepository<Hotel> Hotels { get; }
<<<<<<< HEAD
        IBaseRepository<BookingPay> BookingPays { get; }
        IBaseRepository<Room> Rooms { get; }
=======
>>>>>>> 0c38005145b53f5ecf1f9e94b4dac06654c13534
        IBaseRepository<Customer> Customers { get; }
        IHotelManagerReprository HotelManagers { get; }
        IRoomReopository Rooms { get; }
        void Complete();
    }
}
