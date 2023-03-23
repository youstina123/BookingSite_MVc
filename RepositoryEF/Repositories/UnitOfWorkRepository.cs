
using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Interfaces;
using RepositoryModel.Models;
using RepositoryPatternWithUOW.Core.Repository;
using RepositoryPatternWithUOW.EF.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace RepositoryEF.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
      

        public ApplicationDbContext context;
		public IBaseRepository<AppUser> AppUsers { get; private set; }
         public IRoomReopository Rooms { get; private set; }
        public IBaseRepository<Hotel> Hotels { get; private set; }
       public IHotelManagerReprository HotelManagers { get; private set; }
        public IBaseRepository<Customer> Customers { get; private set; }
<<<<<<< HEAD

        public IBaseRepository<BookingPay> BookingPays { get; private set; }

=======
        
>>>>>>> 0c38005145b53f5ecf1f9e94b4dac06654c13534


        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            this.context = context;
            Hotels = new BaseRepository<Hotel>(this.context);
            HotelManagers = new HotelManagerRepository(this.context);
			AppUsers = new BaseRepository<AppUser>(this.context);

            Rooms=new RoomRepository (this.context);

            Customers = new BaseRepository<Customer>(this.context);

            BookingPays = new BaseRepository<BookingPay>(this.context);




        }

        public void Complete()
        {
             context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
