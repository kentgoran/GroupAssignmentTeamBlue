using GroupAssignmentTeamBlue.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GroupAssignmentTeamBlue.DAL.Context
{
    public class AdvertContext : IdentityDbContext<User, UserRole, int>
    {
        
        public DbSet<Comment> Comments { get; set; }
        
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }


        public AdvertContext(DbContextOptions<AdvertContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasOne(r => r.RatedUser).WithMany(u => u.RatingsRecieved);
            modelBuilder.Entity<Rating>().HasOne(r => r.RatingUser).WithMany(u => u.RatingsMade);
            modelBuilder.Entity<Comment>().HasOne(c => c.RealEstateInQuestion).WithMany(r => r.Comments);
            modelBuilder.Entity<RealEstate>().Property(r => r.Rent).HasColumnType("money");
            modelBuilder.Entity<RealEstate>().Property(r => r.SellPrice).HasColumnType("money");
            //base.OnModelCreating has to be called in order for IdentityDbContext to do it's thing
            base.OnModelCreating(modelBuilder);
        }
    }
}
