using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using RepositoryEF;
using RepositoryEF.Repositories;
using RepositoryModel.Interfaces;

namespace BookingSite.Tests
{
    [TestFixture]
    public class Hotel_ManagerRepositoryTest
    {
        private Mock<ApplicationDbContext> contextMock;
        private IHotelManagerReprository repository;

        [TestInitialize]
        public void Initialize()
        {
            // Initialize the mock context and repository
            var data = new List<Hotel_Manager>
        {
            new Hotel_Manager { HotelId = 1, AppUserId = "user1" },
            new Hotel_Manager { HotelId = 2, AppUserId = "user2" },
            new Hotel_Manager { HotelId = 3, AppUserId = "user3" },
        }.AsQueryable();

            var mockSet = new Mock<DbSet<Hotel_Manager>>();
            mockSet.As<IQueryable<Hotel_Manager>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Hotel_Manager>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Hotel_Manager>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Hotel_Manager>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            contextMock = new Mock<ApplicationDbContext>();
            contextMock.Setup(c => c.Hotel_Managers).Returns(mockSet.Object);

            repository = new HotelManagerRepository(contextMock.Object);
        }
        [TestMethod]
        public void FindMangerId_ReturnsCorrectUserId()
        {
            // Arrange
            int hotelId = 2;

            // Act
            string result = repository.FindMangerId(hotelId);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("user2", result);
        }

        [TestMethod]
        public void FindMangerdetailes_ReturnsCorrectManagerDetails()
        {
            // Arrange
            string userId = "user1";

            // Act
            Hotel_Manager result = repository.FindMangerdetailes(userId);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1", result.AppUserId);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, result.HotelId);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("user1", result.AppUserId);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result.Hotel);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result.AppUser);
        }
    }
}
