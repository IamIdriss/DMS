using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
