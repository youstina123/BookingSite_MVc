using BookingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Interfaces
{
    public interface IRoomReopository:IBaseRepository<Room>
    {
        List<Room> GetllRooms(int id);
        Room GetRoomByID(int id);
        List<Room> GetRelativeRooms(int id);

    }
}
