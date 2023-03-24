using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using RepositoryEF;
using RepositoryEF.Repositories;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.InMemory;

namespace BookingSite.Tests
{
    [TestFixture]
    internal class HotelReviewTests
    {
        private readonly Mock<DbSet<Review>> _mockReviewSet;
        private ApplicationDbContext dbContext;
        private HotelRepository hotelRepository;

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
            hotelRepository = new HotelRepository(dbContext);
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

        }

        [Test]
        public void TestGetReviews()
        {
            HotelRepository hotelRepository = new HotelRepository(dbContext);
            // Arrange
            int hotelId = 1;
            var reviews = new List<Review>
        {
            new Review { Id = 1, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 2, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 3, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 4, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 5, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 6, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 7, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 8, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } },
            new Review { Id = 9, HotelId = 1, IsDeleted = false, Customer = new Customer { AppUser = new AppUser() } }
        };

            _mockReviewSet.As<IQueryable<Review>>().Setup(m => m.Provider).Returns(reviews.AsQueryable().Provider);
            _mockReviewSet.As<IQueryable<Review>>().Setup(m => m.Expression).Returns(reviews.AsQueryable().Expression);
            _mockReviewSet.As<IQueryable<Review>>().Setup(m => m.ElementType).Returns(reviews.AsQueryable().ElementType);
            _mockReviewSet.As<IQueryable<Review>>().Setup(m => m.GetEnumerator()).Returns(reviews.GetEnumerator());

            var expectedReviews = reviews.Where(r => r.IsDeleted == false && r.HotelId == hotelId).OrderByDescending(r => r.Id).Take(8).ToList();

            // var hotelReviewService = new HotelReviewService(_mockContext.Object);

            // Act
            var actualReviews = hotelRepository.getReviews(1);

            // Assert
            CollectionAssert.AreEqual(expectedReviews, actualReviews);
        }
    }   }
