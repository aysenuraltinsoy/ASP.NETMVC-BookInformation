using BooksOnion.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Infrastructure.EntityTypeConfiguration
{
    public class GenreConfig:BaseEntityConfig<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(x => x.GenreID);
            builder.Property(x=>x.GenreID).IsRequired(true);
            builder.Property(x=>x.genreEnum).IsRequired(true);


            base.Configure(builder);
        }
    }
}
