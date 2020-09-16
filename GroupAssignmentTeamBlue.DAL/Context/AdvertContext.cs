using GroupAssignmentTeamBlue.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Bogus.DataSets;

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

            //DbGenerator.Initializer();
            //modelBuilder.Entity<User>().HasData(DbGenerator.GeneratedUsers);

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                UserName = "bamse@gmail.com",
                NormalizedUserName = "BAMSE@GMAIL.COM",
                Email = "bamse@gmail.com",
                NormalizedEmail = "BAMSE@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEAR00VgEXuNcTRL9aekKB86ar4F2D+pRmar9AGvUw/Fnxxe531NIpGwsPAi56bxqTg==",
                SecurityStamp = "DRGRSWDQ5C5MZZBZQUWDGHQRW66QI5D6",
                ConcurrencyStamp = "68e01f8c-ba04-416e-9e53-dab4c5f2e50d",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new User()
            {
                Id = 2,
                UserName = "skalman@gmail.com",
                NormalizedUserName = "SKALMAN@GMAIL.COM",
                Email = "skalman@gmail.com",
                NormalizedEmail = "SKALMAN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEEOcqQ00ZZaNxwRK5lJGV1RPtl7rGeeMIlietoHd62yeavAR3PsuAGrBI8TWClg/qg==",
                SecurityStamp = "P7HU2IDVNJQEYMGXCN55NQHELVS3TECN",
                ConcurrencyStamp = "b3d90eb5-90d9-4f69-97bd-057f32692f84",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new User()
            {
                Id = 3,
                UserName = "alfons@gmail.com",
                NormalizedUserName = "ALFONS@GMAIL.COM",
                Email = "alfons@gmail.com",
                NormalizedEmail = "ALFONS@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEGFDh/g9WmY5IWx5cxkE44yyV5a6ucoFfhUcoe8DmVNIP5Ror9j1dYRxA2zKQMXG0g==",
                SecurityStamp = "K4GFE2ZZLA7BRDI3VWC2M2N2ILHKE6X3",
                ConcurrencyStamp = "4c6ba646-058a-4876-ab51-e681e26f74d3",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new User()
            {
                Id = 4,
                UserName = "laban@gmail.com",
                NormalizedUserName = "LABAN@GMAIL.COM",
                Email = "laban@gmail.com",
                NormalizedEmail = "LABAN@GMAIL.COMm",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEMD595Y3JYWe+nH1AIQhsN6Ft74vry91PDj0/7Mt4ZZoFim856jomEAfq92mo8LHuQ==",
                SecurityStamp = "NW6F2HLUH24CNHBFUNW54LVDZVNG3ALB",
                ConcurrencyStamp = "a638d86b-eac1-4338-90c3-a0f9b42ac60f",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            });
            modelBuilder.Entity<RealEstate>().HasData(new RealEstate()
            {
                Id = 1,
                UserId = 2,
                Title = "Sum",
                Description = "This is a test",
                Contact = "0709-662239",
                Address = "Kulls väg 8",
                Type = GroupAssignmentTeamBlue.Model.Enums.EstateType.Apartment,
                IsRentable = true,
                IsSellable = false,
                Rent = 200,
                YearBuilt = 2019,
                DateOfAdvertCreation = new DateTime(2020, 09, 14, 18, 15, 30)
            },
            new RealEstate()
            {
                Id = 2,
                UserId = 1,
                Title = "Haiii",
                Description = "This is a test",
                Contact = "112",
                Address = "Kulls väg 23",
                Type = GroupAssignmentTeamBlue.Model.Enums.EstateType.Apartment,
                IsRentable = false,
                IsSellable = true,
                SellPrice = 1795000,
                YearBuilt = 2001,
                DateOfAdvertCreation = new DateTime(2020, 09, 13, 12, 28, 30)
            });
            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                Id = 1,
                RatedUserId = 1,
                RatingUserId = 2,
                Score = 4
            },
            new Rating()
            {
                Id = 2,
                RatedUserId = 3,
                RatingUserId = 1,
                Score = 1
            });
            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                Id = 1,
                UserId = 1,
                RealEstateId = 1,
                TimeOfCreation = new DateTime(2020, 09, 16, 17, 9, 12),
                Content = "This apartment is crap..."
            },
            new Comment()
            {
                Id = 2,
                UserId = 2,
                RealEstateId = 1,
                TimeOfCreation = new DateTime(2020, 09, 16, 17, 14, 30),
                Content = "You are just mad because I didn't let you rent it..."
            },
            new Comment()
            {
                Id = 3,
                UserId = 3,
                RealEstateId = 1,
                TimeOfCreation = new DateTime(2020, 09, 16, 17, 30, 29),
                Content = "Woah, *Grabbing popcorn*"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
