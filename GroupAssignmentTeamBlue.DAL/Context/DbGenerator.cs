using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Model.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GroupAssignmentTeamBlue.DAL.Context
{
    public static class DbGenerator
    {
        static DbGenerator()
        {
            GeneratedComments = new List<Comment>();
            GeneratedRatings = new List<Rating>();
            GeneratedUsers = new List<User>();
            GeneratedRealEstates = new List<RealEstate>();
        }
        public static ICollection<Comment> GeneratedComments { get; private set; }
        public static ICollection<Rating> GeneratedRatings { get; private set; }
        public static ICollection<RealEstate> GeneratedRealEstates { get; private set; }
        public static ICollection<User> GeneratedUsers { get; private set; }

        public static void Initializer
            (int numberOfRealEstatesToGenerate = 5, int numberOfRatingsToGenerate = 5, int numberOfCommentsToGenerate = 5)
        {       
            GeneratedUsers = GenerateUsers();
            GeneratedRealEstates = GenerateRealEstates(numberOfRealEstatesToGenerate);
            GeneratedComments = GenerateComments(numberOfCommentsToGenerate);
            GeneratedRatings = GenerateRatings(numberOfRatingsToGenerate);
   
        }
        private static ICollection<RealEstate> GenerateRealEstates(int numberOfRealEstatesToGenerate)
        {
            Randomizer.Seed = new Random(5);
            int id = 1;

            var realEstates = new Faker<RealEstate>()
                .CustomInstantiator(re => new RealEstate())
                .RuleFor(re => re.Id, _ => id++)
                .RuleFor(re => re.Title, t => t.Lorem.Word())
                .RuleFor(re => re.Description, t => t.Lorem.Sentence())
                .RuleFor(re => re.UserId, t => t.Random.Int(1, 4))
                .RuleFor(re => re.Contact, (f, re) =>
                {
                    return $"{f.Name.FullName()}, ${f.Address.FullAddress()}";
                })
                .RuleFor(re => re.Address, f => f.Address.FullAddress())
                .RuleFor(re => re.Type, f => f.Random.Enum<EstateType>())
                .RuleFor(re => re.IsRentable, f => f.Random.Bool())
                .RuleFor(re => re.IsSellable, (f, re) =>
                {
                    return !re.IsRentable;
                })
                .RuleFor(re => re.Rent, (f, re) =>
                {
                    return re.IsRentable ? Math.Round(f.Random.Decimal(4500, 12500)) : 0;
                })
                .RuleFor(re => re.SellPrice, (f, re) =>
                {
                    return re.IsSellable ? Math.Round(f.Random.Decimal(100000, 3000000)) : 0;
                })
                .RuleFor(re => re.ConstructionYear, f => f.Random.Int(1600, DateTime.Now.Year))
                .RuleFor(re => re.DateOfAdvertCreation, (f, re) =>
                {
                    return f.Date.Between(new DateTime(re.ConstructionYear, 01, 01), new DateTime(re.ConstructionYear, 12, 31));
                })
                .RuleFor(re => re.City, f => f.Address.City())
                .RuleFor(re => re.ListingUrl, f => f.Internet.Url())
                .RuleFor(re => re.SquareMeters, f => f.Random.Int(5, 5000))
                .RuleFor(re => re.Rooms, f => f.Random.Int(1,50));

            var users = realEstates.Generate(numberOfRealEstatesToGenerate);
            return users;
        }
        private static ICollection<User> GenerateUsers()
        {
            var result = new List<User>()
            {
                new User()
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
                }
            };
            return result;
        }
        private static ICollection<Comment> GenerateComments(int count)
        {
            int ids = GeneratedComments.Count() + 1;

            var commentGenerator = new Faker<Comment>()
                .RuleFor(r => r.Id, _ => ids++)
                .RuleFor(r => r.RealEstateId, f => f.Random.Int(1, GeneratedRealEstates.Count()))
                .RuleFor(r => r.TimeOfCreation, f => f.Date.Recent())
                .RuleFor(r => r.UserId, f => f.Random.Int(1, 4))
                .RuleFor(r => r.Content, f => f.Lorem.Sentence());

            return commentGenerator.Generate(count);
        }

        private static ICollection<Rating> GenerateRatings(int count)
        {
            int ids = GeneratedRatings.Count() + 1;

            var ratingGenerator = new Faker<Rating>()
                .RuleFor(r => r.Id, _ => ids++)
                .RuleFor(r => r.RatedUserId, f => f.Random.Int(1, 4))
                .RuleFor(r => r.RatingUserId, (f, r) => {
                    int ratingUserId = 0;
                    do
                    {
                        ratingUserId = f.Random.Int(1, 4);
                    } while (ratingUserId != r.RatedUserId);

                    return ratingUserId;
                })
                .RuleFor(r => r.Score, f => f.Random.Int(1, 5));

            return ratingGenerator.Generate(count);
        }

    }
}
