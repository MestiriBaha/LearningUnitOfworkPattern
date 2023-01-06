using LearningUnitOfworkPattern.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _context; 
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match); }
        //Arrow Function Type 
        public IEnumerable<T> GetAll() =>  _context.Set<T>().ToList();  
         

        public T GetByID(int id)
        {

            return _context.Set<T>().Find(id); 
        }
        public T Add ( T entity)
        {
            _context.Set<T>() .Add(entity);
            _context.SaveChanges();
            return entity; 
        }
        public T Update(T entity)
        {
            _context.Update(entity);
            return (entity);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
   
}
