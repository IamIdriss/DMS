using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Content)
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(x => x.DateCreated)

             .HasDefaultValueSql("getdate()");
        }
    }
}
