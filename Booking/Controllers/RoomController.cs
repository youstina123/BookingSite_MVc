//using Booking.Repository;
using BookingLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Interfaces;
using RepositoryPatternWithUOW.Core.Repository;
using System;

namespace Booking.Controllers
{
    public class RoomController : Controller
    {

        IUnitOfWorkRepository roomReopository;
        public RoomController(IUnitOfWorkRepository _roomReopository)
        {
            this.roomReopository = _roomReopository;
        }

        public IActionResult Details(int id)
        {

            Room room = roomReopository.Rooms.GetRoomByID(id);

            if (room != null)
            {
                List<Room> rooms = roomReopository.Rooms.GetRelativeRooms(id);
                if (rooms != null && rooms.Count > 0)
                {
                    ViewData["RelativeRooms"] = rooms;
                }



                string userName = "";
                if (User.Identity.IsAuthenticated)
                {
                    userName = User.Identity.Name.ToString();
                    ViewData["User"] = userName;
                }
                return View(room);
            }
            else
                return Content("Error");

        }

    }
}
