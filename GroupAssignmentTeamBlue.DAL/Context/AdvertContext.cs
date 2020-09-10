using GroupAssignmentTeamBlue.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GroupAssignmentTeamBlue.DAL.Context
{
    public class AdvertContext : IdentityDbContext<User, UserRole, int>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }

        //This constructor is to be used after creating the database, but needs to be commented out in early dev, as applying migrations does not
        //work with dependency injection
        public AdvertContext(DbContextOptions<AdvertContext> options) : base(options)
        {

        }

        //Comment out this OnConfiguring when NOT applying migrations, as well as un-commenting out the constructor above
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=AdvertTeamBlue; Integrated Security=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasOne(r => r.RatedUser).WithMany(u => u.RatingsRecieved);
            modelBuilder.Entity<Rating>().HasOne(r => r.RatingUser).WithMany(u => u.RatingsMade);
            //base.OnModelCreating has to be called in order for IdentityDbContext to do it's thing
            base.OnModelCreating(modelBuilder);
        }
    }
}
