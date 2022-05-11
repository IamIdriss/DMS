using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMS.Data.Configurations
{
    public class AgentConfiguration :IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.Property(x => x.LastName)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.FirstName)
            .HasMaxLength(50)
            .IsRequired();

            builder
               .HasOne(p => p.Department)
               .WithMany(b => b.Agents)
               .HasForeignKey(p => p.DepartmentId);
        }
    }
}
