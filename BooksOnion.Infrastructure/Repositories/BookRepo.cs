using BooksOnion.Domain.Entities;
using BooksOnion.Domain.Repositories;
using BooksOnion.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Infrastructure.Repositories
{
    public class BookRepo : BaseRepo<Book>, IBookRepo
    {
        public BookRepo(BooksDbContext bookDbContext) : base(bookDbContext)
        {
        }
    }
}
