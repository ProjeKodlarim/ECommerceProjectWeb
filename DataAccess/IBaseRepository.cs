using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IBaseRepository<T> where T:class,IEntity, new()
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> filter=null);
        Task<T> Get(Expression<Func<T,bool>> filter);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
        Task<T> Update(T entity);
    }
}
