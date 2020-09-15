using System;
using System.Collections.Generic;
using System.Linq;
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
        private static UserManager<User> _userManager;

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
            GenerateRealEstates(5);
            GenerateRatings();
        }
        private static void GenerateRealEstates(int count)
        {
            Randomizer.Seed = new Random(12346);

            for (int i = 0; i < count; i++)
            {
                var realEstateGenerator = new Faker<RealEstate>()
                .RuleFor(re => re.Title, f => f.Random.Words(3))
                .RuleFor(re => re.Description, f => f.Lorem.Text())
                .RuleFor(re => re.Contact, (f, re) => {
                    return $"{f.Name.FullName()}, {f.Phone.PhoneNumber()}";
                })
                .RuleFor(re => re.User, GenerateUser())
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
                .RuleFor(re => re.Address, (f, re) => {

                    return $"{f.Address.FullAddress()}";
                });

                GeneratedRealEstates.Add(realEstateGenerator);
            }
        }
        private static void GenerateRatings()
        {
            Randomizer.Seed = new Random(12346);
            var realEstateGenerator = new Faker<RealEstate>()
                //Generates a title of 3 words
                .RuleFor(re => re.Title, f => f.Random.Words(3))
                .RuleFor(re => re.Description, f => f.Lorem.Text())
                .RuleFor(re => re.Contact, (f, re) => {
                    return $"{f.Name.FullName()}, {f.Phone.PhoneNumber()}";
                })
                .RuleFor(re => re.User, GenerateUser())
                .RuleFor(re => re.IsRentable, f => f.Random.Bool())
                //IsSellable becomes the oposite of IsRentable
                .RuleFor(re => re.IsSellable, (f, re) =>
                {
                    return !re.IsRentable;
                })
                //Randomizes field of enum EstateTyoe
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

                    return $"{f.Address.FullAddress()}"; ;
                });

        }
        private static User GenerateUser()
        {
            var user = new Faker<User>()
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.Email, f => f.Internet.Email());

            _userManager.CreateAsync(user);
            _userManager.AddPasswordAsync(user, "Blå1234");

            GeneratedUsers.Add(user);
            return user;
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
