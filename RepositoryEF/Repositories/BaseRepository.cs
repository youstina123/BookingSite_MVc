
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RepositoryEF;
using RepositoryModel.Interfaces;
using RepositoryPatternWithUOW.Core.Repository;
using RepositoryPatternWithUOW.EF;

namespace RepositoryPatternWithUOW.EF.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        ApplicationDbContext context;
        IUnitOfWorkRepository unitOfWork;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public BaseRepository(ApplicationDbContext context, IUnitOfWorkRepository unitOfWork)
        {
            this.context = context;
            this.unitOfWork = unitOfWork;
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }
		public T GetByIDString(string id)
		{
			return context.Set<T>().Find(id);
		}

		public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
           Update(entity);
          

        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();

        }

      
        public void Update(T entity)
        {
			//context.Set<T>().Attach(entity);
			//context.Entry(entity).State = EntityState.Modified;
			context.Update(entity);
            context.SaveChanges();
			//unitOfWork.Complete();
			//return entity;
		}

        public T Find(Expression<Func<T, bool>> match)
        {
            return context.Set<T>().Find(match);
        }

        public T Find(Expression<Func<T, bool>> match, string[] includes=null)
        {
            IQueryable<T> query = context.Set<T>();
            if(includes != null)
            {
                foreach(var iclude in includes)
                {
                    query = query.Include(iclude);
                }
            }
            return query.SingleOrDefault(match);
        }

       public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null)
        
        {
            IQueryable<T> query = context.Set<T>();
            if (includes != null)
            {
                foreach (var iclude in includes)
                {
                    query = query.Include(iclude);
                }
            }
            return query.Where(match).ToList();
        }

        //public IEnumerable<T> FindAllinclude(Expression<Func<T, bool>> match, string[] includes = null, string[] includes2 = null)
        //{
        //   T entity= Find(match, includes);
        //    IQueryable<T> query = context.Set<T>();
        //    if (includes != null)
        //    {
        //        foreach (var iclude in includes)
        //        {
        //            query = query.Include(iclude);

        //        }
        //    }
        //    return query.Where(match).ToList();
        //}



       



    }
}
