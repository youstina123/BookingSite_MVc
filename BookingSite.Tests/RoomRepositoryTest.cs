using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using NUnit.Framework;
using RepositoryEF;
using RepositoryEF.Repositories;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Tests
{
    [TestFixture]
    public class RoomRepositoryTest
    {
        private ApplicationDbContext dbContext;
        private RoomRepository roomRepository;

        [SetUp]
        public void Setup()
        {
            // Set up a test database with some sample data
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            dbContext = new ApplicationDbContext(options);
            SeedData(dbContext);

            // Create an instance of the RoomRepository using the test database context
            roomRepository = new RoomRepository(dbContext);
        }

        [Test]
        public void GetllRooms_ReturnsRoomsByHotelId()
        {
            // Arrange
            int hotelId = 1;

            // Act
            var result = roomRepository.GetllRooms(hotelId);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(r => r.HotelId == hotelId));
        }

        [Test]
        public void GetRelativeRooms_ReturnsSimilarRooms()
        {
            // Arrange
            int roomId = 1;

            // Act
            var result = roomRepository.GetRelativeRooms(roomId);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(2, result[0].Id);
        }

        [Test]
        public void GetRoomByID_ReturnsRoomById()
        {
            // Arrange
            int roomId = 1;

            // Act
            var result = roomRepository.GetRoomByID(roomId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(roomId, result.Id);
        }

        private void SeedData(ApplicationDbContext dbContext)
        {
            var hotel1 = new Hotel
            {
                Id = 1,
                Name = "Hotel A",
                Description = "descijadsjkaksjdkjaskdjkasd",
                Rate = Hotel_Rate_Star.FiveStars,
                City = "Assuit",
                Country = "Egypt",
                Street = "lkkkasj",
                Hotel_ManagerId = "1",
                IsConfermed = true,
                IsDeleted = false
            };
            var hotel2 = new Hotel
            {
                Id = 2,
                Name = "Hotel B",
                Description = "descijadsjkaksjdkjaskdjkasd",
                Rate = Hotel_Rate_Star.SevenStars,
                City = "Assuit1",
                Country = "Egypt1",
                Street = "lkkkasj1111",
                Hotel_ManagerId = "2",
                IsConfermed = true,
                IsDeleted = false
            };

            var room1 = new Room { Id = 1, HotelId = 1, Cost_Per_Night = 50, IsNormalRoom = true, Description = "lkajkshdjhasjd", ISavailable = true, IsDeleted = false, Normal_RoomId = 1, Room_Num = 123 };
            var normalRoom1 = new Normal_Room { RoomId = room1.Id, Type_Of_Room = Type_Of_Room.Single };
            room1.Normal_Room = normalRoom1;

            var room2 = new Room { Id = 2, HotelId = 1, Cost_Per_Night = 500, IsNormalRoom = true, Description = "lkajkshdjhasjd", ISavailable = true, IsDeleted = false, Normal_RoomId = 2, Room_Num = 113 };
            var normalRoom2 = new Normal_Room { RoomId = room2.Id, Type_Of_Room = Type_Of_Room.Double };
            room2.Normal_Room = normalRoom2;

            var room3 = new Room { Id = 3, HotelId = 2, Cost_Per_Night = 1500, IsNormalRoom = false, Description = "suitdesc", ISavailable = true, IsDeleted = false, SuitId = 3, Room_Num = 1111 };
            var suit1 = new Suit { RoomId = room3.Id, Num_Of_Rooms = 2 };
            room3.Suit = suit1;

            dbContext.AddRange(hotel1, hotel2, room1, room2, room3);
            dbContext.SaveChanges();
        }
    }
}
