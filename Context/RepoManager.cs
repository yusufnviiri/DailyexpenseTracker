using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Context
{
    public abstract class RepoManager<T> : IRepoBase<T> where T : class
    {
      protected AppDbContext _db;
        public RepoManager(AppDbContext db)
        {
            _db= db;
            
        }
       
      public void Create(T entity) => _db.Set<T>().Add(entity);
      public IEnumerable<T> GetAll()=>_db.Set<T>();

    }
}
