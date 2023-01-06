using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetByID(int id); 
        IEnumerable<T> GetAll();
        T Find(Expression<Func<T, bool>> match);
        T Add (T entity);   
        void Delete(T entity); 
        T Update ( T entity);   
    }
}
