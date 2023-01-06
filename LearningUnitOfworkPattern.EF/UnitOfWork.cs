using LearningUnitOfworkPattern.core;
using LearningUnitOfworkPattern.core.Interfaces;
using LearningUnitOfworkPattern.core.Models;
using LearningUnitOfworkPattern.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Author> Authors { get; private set; }

        public IBaseRepository<Book> Books { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new BaseRepository<Author>(_context);
            Books = new BaseRepository<Book>(_context);

        }

        public int complete()
        {
            return _context.SaveChanges(); 
        }

        public void Dispose()
        {
            _context.Dispose(); 
        }
    }
}
