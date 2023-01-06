using LearningUnitOfworkPattern.core.Interfaces;
using LearningUnitOfworkPattern.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.EF.Repositories
{
    public class BookRepository :  BaseRepository<Book>,IBookRepository
    {
        private readonly ApplicationDbContext _applicationDbContext ;   
        public BookRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    
        public void SpecialMethod()
        {
            throw new NotImplementedException();    
        }
        
    }
}
