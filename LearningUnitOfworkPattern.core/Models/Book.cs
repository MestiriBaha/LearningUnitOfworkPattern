using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitOfworkPattern.core.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required , MaxLength(50)]
        public string?  Title { get; set; }
        public Author? Author { get; set; }
        public int AuthorID { get; set;  }

    }
}
