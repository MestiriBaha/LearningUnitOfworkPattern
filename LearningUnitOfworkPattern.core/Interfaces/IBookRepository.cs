using LearningUnitOfworkPattern.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.core.Interfaces
{
    public interface IBookRepository :  IBaseRepository<Book> 
    {
         void SpecialMethod(); 
    }
}
