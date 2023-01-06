using LearningUnitOfworkPattern.core.Interfaces;
using LearningUnitOfworkPattern.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Author> Authors { get; }    
       IBookRepository Books { get; }
        int complete(); 
    }
}
