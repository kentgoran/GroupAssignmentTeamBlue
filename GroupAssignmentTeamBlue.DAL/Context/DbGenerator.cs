using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
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
            GeneratedRealEstates = new List<RealEstate>();
            GeneratedUsers = new List<User>();

        }
        public static ICollection<Comment> GeneratedComments { get; private set; }
        public static ICollection<Rating> GeneratedRatings { get; set; }
        public static ICollection<RealEstate> GeneratedRealEstates { get; private set; }
        public static ICollection<User> GeneratedUsers { get; private set; }

        public static void Initializer()
        {
            GenerateUsers();
            GenerateRealEstates(5);
        }
        private static void GenerateRealEstates(int count)
        {
            Randomizer.Seed = new Random(12346);

            for (int i = 0; i < count; i++)
            {
                var realEstateGenerator = new Faker<RealEstate>()
                .RuleFor(re => re.Title, f => f.Random.Words(3))
                .RuleFor(re => re.Description, f => f.Lorem.Text())
                .RuleFor(re => re.Contact, (f, re) =>
                {
                    return $"{f.Name.FullName()}, {f.Phone.PhoneNumber()}";
                })
                .RuleFor(re => re.User, (f, re) => {
                    int userSpot = f.Random.Int(0, (GeneratedUsers.Count() - 1));
                    return GeneratedUsers.ToList()[userSpot];
                
                })
                .RuleFor(re => re.IsRentable, f => f.Random.Bool())
                .RuleFor(re => re.IsSellable, (f, re) =>
                {
                    return !re.IsRentable;
                })
                .RuleFor(re => re.Type, f => f.Random.Enum<EstateType>())
                .RuleFor(re => re.Rent, (f, re) =>
                {
                    return re.IsRentable ? (decimal?)f.Random.Decimal(4000, 15000) : null;
                })
                .RuleFor(re => re.SellPrice, (f, re) =>
                {
                    return re.IsSellable ? (decimal?)f.Random.Decimal(100000, 2500000) : null;
                })
                .RuleFor(re => re.YearBuilt, f => f.Random.Int(1600, 2022))
                .RuleFor(re => re.DateOfAdvertCreation, (f, re) =>
                {
                    return f.Date.Between(Convert.ToDateTime(re.YearBuilt - 01 - 01), Convert.ToDateTime(re.YearBuilt - 01 - 01));
                })
                .RuleFor(re => re.Comments, (f, re) =>
                {
                    return GenerateComments(re.User, re, f.Random.Int(0, 5));
                })
                .RuleFor(re => re.Address, (f, re) =>
                {

                    return $"{f.Address.FullAddress()}";
                });

                GeneratedRealEstates.Add(realEstateGenerator);
            }
        }
        private static ICollection<User> GenerateUsers()
        {
            var result =  new List<User>()
            {
                new User()
                {
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
            GeneratedUsers = result;
            return result;
        }
        private static ICollection<Comment> GenerateComments(User user, RealEstate realEstate, int count)
        {
            var minDate = Convert.ToDateTime(1600 - 01 - 01);
            var result = new List<Comment>();

            for (int i = 0; i < count; i++)
            {
                var comment = new Faker<Comment>()
                .RuleFor(c => c.Content, f => f.Lorem.Sentence())
                .RuleFor(c => c.User, user)
                .RuleFor(c => c.TimeOfCreation, f => f.Date.Between(minDate, DateTime.Now.Date))
                .RuleFor(c => c.RealEstateInQuestion, realEstate);

                result.Add(comment);
                GeneratedComments.Add(comment);
            }

            return result;
        }
    }
}
