using Microsoft.EntityFrameworkCore;
using UNeedTickets.Models;

namespace UNeedTickets.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tickets> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Horror", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Tickets>().HasData(
                new Tickets { Id = 1, Title= "Hardware Defects D-4", Summary="The devices is not working", 
                    Description="2023-3-13 Blah Blah Blah ...", Status="OPEN", ResolvedorNot=false }
                );
        }
    }
}
