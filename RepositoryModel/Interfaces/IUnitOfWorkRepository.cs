using BookingLibrary.Models;
using RepositoryModel.Interfaces;

namespace RepositoryPatternWithUOW.Core.Repository
{
    public interface IUnitOfWorkRepository: IDisposable
    {
        //IBaseRepository<UnitOfWork> BaseRepository { get; }
       IBaseRepository<AppUser> AppUsers { get; }
        IBaseRepository<Hotel> Hotels { get; }
        IBaseRepository<Hotel_Manager> HotelManagers { get; }
        void Complete();
    }
}
