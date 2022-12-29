using BooksOnion.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Domain.Entities
{
    public class Book:IBaseEntity
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int NumberOfPage { get; set; }
        public int? Point { get; set; }
        public int? AuthorID { get; set; }
        public virtual Author? Author { get; set; }
        public int? GenreID { get; set; }
        public virtual Genre? Genre { get; set; }
        public GenreEnum genreEnum { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; } = Status.Active;

    }
}
