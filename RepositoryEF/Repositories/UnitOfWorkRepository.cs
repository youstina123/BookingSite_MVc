
using BookingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Interfaces;
using RepositoryPatternWithUOW.Core.Repository;
using RepositoryPatternWithUOW.EF.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace RepositoryEF.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
      

        public ApplicationDbContext context;
		public IBaseRepository<AppUser> AppUsers { get; private set; }

		public IBaseRepository<Hotel> Hotels { get; private set; }
       public IBaseRepository<Hotel_Manager> HotelManagers { get; private set; }

        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            this.context = context;
            Hotels = new BaseRepository<Hotel>(this.context);
            HotelManagers = new BaseRepository<Hotel_Manager>(this.context);
			AppUsers = new BaseRepository<AppUser>(this.context);

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
