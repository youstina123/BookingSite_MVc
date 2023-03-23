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

        IBaseRepository<Room> Rooms { get; }

        IHotelManagerReprository HotelManagers { get; }
        void Complete();
    }
}
