using BooksOnion.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Domain.Entities
{
    public class Genre:IBaseEntity
    {
        public int GenreID { get; set; }
        public GenreEnum  genreEnum { get; set; }
        public virtual List<Book> Books { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; } = Status.Active;
      
    }
}
