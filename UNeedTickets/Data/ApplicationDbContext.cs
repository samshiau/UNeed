using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using UNeedTickets.Models;

namespace UNeedTickets.Data
{
    [NotMapped]
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Horror", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
           // modelBuilder.Entity<Tickets>().HasData(
             //   new Tickets { Id = 1, Title= "Hardware Defects D-4", Summary="The devices is not working", 
              //      Description="2023-3-13 Blah Blah Blah ...", Status="OPEN", ResolvedorNot=false }
             //   );
        }
    }
}
