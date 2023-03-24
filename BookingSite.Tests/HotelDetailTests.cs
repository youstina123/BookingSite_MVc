using NUnit.Framework;
using RepositoryEF.Repositories;
using RepositoryEF;

namespace BookingSite.Tests
{
    [TestFixture]
    public class HotelDetailTests
    {

        [Test]

        public void GetSuit_ReturnsCorrectSuit()
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            HotelRepository hotelDetail = new HotelRepository(applicationDbContext);
            var result = hotelDetail.getsuit(1);


            Assert.IsNotNull(result);
        }

        [Test]
        public void GetPhotos_Test()
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            HotelRepository hotelDetail = new HotelRepository(applicationDbContext);
            List<string> result = hotelDetail.getphoto(1);
            List<string> expected = new List<string> { "about.jpg" };

            Assert.AreEqual(expected, result);
        }

    }
}