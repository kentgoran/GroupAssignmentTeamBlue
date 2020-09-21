using GroupAssignmentTeamBlue.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Bogus.DataSets;
using Bogus;
using GroupAssignmentTeamBlue.Model.Enums;

namespace GroupAssignmentTeamBlue.DAL.Context
{
    public class AdvertContext : IdentityDbContext<User, UserRole, int>
    {
        
        public DbSet<Comment> Comments { get; set; }
        
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public AdvertContext(DbContextOptions<AdvertContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasOne(r => r.RatedUser).WithMany(u => u.RatingsRecieved).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Rating>().HasOne(r => r.RatingUser).WithMany(u => u.RatingsMade).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Comment>().HasOne(c => c.RealEstateInQuestion).WithMany(r => r.Comments).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<RealEstate>().Property(r => r.Rent).HasColumnType("money");
            modelBuilder.Entity<RealEstate>().Property(r => r.SellPrice).HasColumnType("money");


            //DbGenerator.Initializer();
            //modelBuilder.Entity<User>().HasData(DbGenerator.GeneratedUsers);

            DbGenerator.Initializer(20, 40, 60);

            modelBuilder.Entity<User>().HasData(DbGenerator.GeneratedUsers);
            modelBuilder.Entity<RealEstate>().HasData(DbGenerator.GeneratedRealEstates);
            modelBuilder.Entity<Comment>().HasData(DbGenerator.GeneratedComments);
            modelBuilder.Entity<Rating>().HasData(DbGenerator.GeneratedRatings);

            base.OnModelCreating(modelBuilder);
        }
    }
}
