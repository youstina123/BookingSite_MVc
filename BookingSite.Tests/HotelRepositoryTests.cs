using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml;
using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using RepositoryEF;
using RepositoryModel.Interfaces;
using RepositoryPatternWithUOW.Core.Repository;
using RepositoryPatternWithUOW.EF.Repository;

namespace BookingSite.Tests
{
    public class HotelRepositoryTests
    {
        [Test]
        public void GetByID_Should_Return_Hotel_With_Given_Id()
        {
            // Arrange
            var entities = new List<Hotel>
         {
           new Hotel { Id = 1 },
           new Hotel { Id = 2 },
           new Hotel { Id = 3 }
         };

            var mockSet = new Mock<DbSet<Hotel>>();
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Provider).Returns(entities.AsQueryable().Provider);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Expression).Returns(entities.AsQueryable().Expression);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.ElementType).Returns(entities.AsQueryable().ElementType);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.GetEnumerator()).Returns(entities.AsQueryable().GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(m => m.Set<Hotel>()).Returns(mockSet.Object);

            var repository = new BaseRepository<Hotel>(mockContext.Object);

            // Act
            var result = repository.GetByID(1);

            // Assert
            NUnit.Framework.Assert.IsNotNull(result);
            NUnit.Framework.Assert.AreEqual(1, result.Id);
        }

        [Test]
        public void GetByID_Should_Return_Null_If_Hotel_With_Given_Id_Does_Not_Exist()
        {
            // Arrange
            var entities = new List<Hotel>();
            var mockSet = new Mock<DbSet<Hotel>>();
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Provider).Returns(entities.AsQueryable().Provider);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Expression).Returns(entities.AsQueryable().Expression);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.ElementType).Returns(entities.AsQueryable().ElementType);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.GetEnumerator()).Returns(entities.AsQueryable().GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Set<Hotel>()).Returns(mockSet.Object);

            var repository = new BaseRepository<Hotel>(mockContext.Object);

            // Act
            var result = repository.GetByID(1);

            // Assert
            NUnit.Framework.Assert.IsNull(result);
        }

        [Test]
        public void Add_Should_Add_Hotel_To_Database()
        {
            // Arrange
            var entities = new List<Hotel>();
            var mockSet = new Mock<DbSet<Hotel>>();
            mockSet.Setup(m => m.Add(It.IsAny<Hotel>())).Callback<Hotel>((s) => entities.Add(s));
            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Set<Hotel>()).Returns(mockSet.Object);
            var unitOfWork = new Mock<IUnitOfWorkRepository>();
            var repository = new BaseRepository<Hotel>(mockContext.Object, unitOfWork.Object);
            var entity = new Hotel { Name = "Test Entity" };

            // Act
            var result = repository.Add(entity);

            // Assert
            NUnit.Framework.Assert.IsNotNull(result);
            NUnit.Framework.Assert.AreEqual(entity, result);
            NUnit.Framework.Assert.IsTrue(entities.Contains(entity));
            mockSet.Verify(m => m.Add(It.IsAny<Hotel>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Test]
        public void Add_Should_Throw_Exception_If_Hotel_Is_Null()
        {
            // Arrange
            var context = new ApplicationDbContext();
            var repository = new BaseRepository<Hotel>(context);

            // Act & Assert
            NUnit.Framework.Assert.Throws<ArgumentNullException>(() => repository.Add(null));
        }


        [Test]
        public void Update_Should_Update_Hotel_In_Database()
        {
            // Arrange
            var entities = new List<Hotel>
            {
                  new Hotel { Id = 1, Name = "Test Entity" }
             };
            var mockSet = new Mock<DbSet<Hotel>>();
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Provider).Returns(entities.AsQueryable().Provider);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Expression).Returns(entities.AsQueryable().Expression);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.ElementType).Returns(entities.AsQueryable().ElementType);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.GetEnumerator()).Returns(entities.AsQueryable().GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Set<Hotel>()).Returns(mockSet.Object);

            var repository = new BaseRepository<Hotel>(mockContext.Object);
            var entity = new Hotel { Id = 1, Name = "Test Entity" };
            repository.Add(entity);

            // Act
            entity.Name = "Updated Entity";
            repository.Update(entity);

            // Assert
            var result = repository.GetByID(1);
            NUnit.Framework.Assert.AreEqual("Updated Entity", result.Name);
        }

        [Test]
        public void Update_Should_Throw_Exception_If_Hotel_Is_Not_Attached_To_Context()
        {
            // Arrange
            var entities = new List<Hotel>();
            var mockSet = new Mock<DbSet<Hotel>>();
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Provider).Returns(entities.AsQueryable().Provider);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Expression).Returns(entities.AsQueryable().Expression);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.ElementType).Returns(entities.AsQueryable().ElementType);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.GetEnumerator()).Returns(entities.AsQueryable().GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Set<Hotel>()).Returns(mockSet.Object);

            var repository = new BaseRepository<Hotel>(mockContext.Object);
            var entity = new Hotel { Id = 1, Name = "Test Entity" };

            // Act & Assert
            NUnit.Framework.Assert.Throws<InvalidOperationException>(() => repository.Update(entity));
        }

        [Test]
        public void Update_Should_Throw_Exception_If_Hotel_Is_Null()
        {
            // Arrange
            var entities = new List<Hotel>();
            var mockSet = new Mock<DbSet<Hotel>>();
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Provider).Returns(entities.AsQueryable().Provider);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.Expression).Returns(entities.AsQueryable().Expression);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.ElementType).Returns(entities.AsQueryable().ElementType);
            mockSet.As<IQueryable<Hotel>>().Setup(m => m.GetEnumerator()).Returns(entities.AsQueryable().GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(c => c.Set<Hotel>()).Returns(mockSet.Object);

            var repository = new BaseRepository<Hotel>(mockContext.Object);

            // Act & Assert
            NUnit.Framework.Assert.Throws<ArgumentNullException>(() => repository.Update(null));
        }
    }
}
