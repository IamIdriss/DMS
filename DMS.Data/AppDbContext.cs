using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            //Primary Key
            modelBuilder.Entity<Agent>()
                .HasKey(a => a.Id);
               
            modelBuilder.Entity<Department>()
                .HasKey(d=>d.Id);
            modelBuilder.Entity<Document>()
                .HasKey(d => d.Id);
                
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            //Foreign Key
            modelBuilder.Entity<Agent>()
                .HasOne(p => p.Department)
                .WithMany(b => b.Agents)
                .HasForeignKey(p => p.DepartmentId);
            modelBuilder.Entity<Document>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Documents)
                .HasForeignKey(p => p.CategoryId);

        }
          

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
