using BooksOnion.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Infrastructure.EntityTypeConfiguration
{
    public class AuthorConfig:BaseEntityConfig<Author>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.AuthorID);
            builder.Property(x=>x.FirstName).IsRequired(true);
            builder.Property(x=>x.LastName).IsRequired(true);
            builder.Property(x=>x.Address).IsRequired(false);

            base.Configure(builder);
        }
    }
}
