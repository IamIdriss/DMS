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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Abbrevation)
            .HasMaxLength(30)
            .IsRequired();

            builder.Property(x => x.City)
            .HasMaxLength(40)
            .IsRequired();
        }
    }
}
