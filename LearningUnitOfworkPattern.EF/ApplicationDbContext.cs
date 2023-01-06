﻿using LearningUnitOfworkPattern.core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base( options )  
        {

        }
        public DbSet<Author> Authors { get; set;  }
        public DbSet<Book> Books { get; set; }  

    }
}
