using BooksOnion.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksOnion.Infrastructure.EntityTypeConfiguration
{
    public class BookConfig:BaseEntityConfig<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookID);
            builder.Property(x=>x.BookName).IsRequired(true);
            builder.Property(x=>x.Point).IsRequired(false);

            builder.HasOne(x => x.Genre)
                .WithMany(x => x.Books)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x=>x.Author)
                .WithMany(x => x.Books)
                .OnDelete(DeleteBehavior.Restrict);
            base.Configure(builder);
        }
    }
}
