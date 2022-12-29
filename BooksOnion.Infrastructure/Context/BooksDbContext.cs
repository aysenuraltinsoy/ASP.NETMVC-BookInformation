using BooksOnion.Domain.Entities;
using BooksOnion.Infrastructure.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Infrastructure.Context
{
    public class BooksDbContext:DbContext
    {

       
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {

        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
