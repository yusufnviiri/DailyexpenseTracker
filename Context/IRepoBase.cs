using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Context
{
    public interface IRepoBase<T> where T : class
    {
        void Create(T entity);  
        IEnumerable<T> GetAll();
    }
}
