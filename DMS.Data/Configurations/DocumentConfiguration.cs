using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder
               .HasOne(p => p.Category)
               .WithMany(b => b.Documents)
               .HasForeignKey(p => p.CategoryId);

            builder.Property(x => x.DateCreated)

             .HasDefaultValueSql("getdate()");
        }
    }
}
