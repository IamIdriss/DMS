using DMS.Data.Configurations;
using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
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
           

            modelBuilder.ApplyConfiguration(new AgentConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }


        public DbSet<Agent> Agents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
