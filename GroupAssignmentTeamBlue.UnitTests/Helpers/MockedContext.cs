using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.EntityFrameworkCore;
using Moq;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupAssignmentTeamBlue.UnitTests.Helpers
{
    internal class MockedContext : Mock<AdvertContext>
    {
        public MockedDbSet<Comment> CommentsDbSet { get; set; }
        public MockedDbSet<Picture> PicturesDbSet { get; set; }
        public MockedDbSet<Rating> RatingsDbSet { get; set; }
        public MockedDbSet<RealEstate> RealEstatesDbSet { get; set; }
        public MockedDbSet<User> UsersDbSet { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Picture> Pictures { get; set; }
        public List<Rating> Ratings { get; set; } 
        public List<RealEstate> RealEstates { get; set; }
        public List<User> Users { get; set; }

        /// <summary>
        /// Creates a MockedContext with generated testdata
        /// </summary>
        /// <param name="opt"></param>
        public MockedContext(DbContextOptions opt) : base(opt)
        {
            GenerateTestData();

            CommentsDbSet = new MockedDbSet<Comment>(Comments);
            PicturesDbSet = new MockedDbSet<Picture>(Pictures);
            RatingsDbSet = new MockedDbSet<Rating>(Ratings);
            RealEstatesDbSet = new MockedDbSet<RealEstate>(RealEstates);
            UsersDbSet = new MockedDbSet<User>(Users);

            SetupDbSets();
        }

        public MockedContext(IEnumerable<Comment> comments, IEnumerable<Picture> pictures,
            IEnumerable<Rating> ratings, IEnumerable<RealEstate> realEstates,
            IEnumerable<User> users, DbContextOptions opt) : base(opt)
        {
            CommentsDbSet = new MockedDbSet<Comment>(comments);
            PicturesDbSet = new MockedDbSet<Picture>(pictures);
            RatingsDbSet = new MockedDbSet<Rating>(ratings);
            RealEstatesDbSet = new MockedDbSet<RealEstate>(realEstates);
            UsersDbSet = new MockedDbSet<User>(users);

            SetupDbSets();
        }

        private void SetupDbSets()
        {
            this.Setup(c => c.Set<Comment>()).Returns(CommentsDbSet.Object);
            this.Setup(c => c.Comments).Returns(CommentsDbSet.Object);

            this.Setup(c => c.Set<Picture>()).Returns(PicturesDbSet.Object);
            this.Setup(c => c.Pictures).Returns(PicturesDbSet.Object);

            this.Setup(c => c.Set<Rating>()).Returns(RatingsDbSet.Object);
            this.Setup(c => c.Ratings).Returns(RatingsDbSet.Object);

            this.Setup(c => c.Set<RealEstate>()).Returns(RealEstatesDbSet.Object);
            this.Setup(c => c.RealEstates).Returns(RealEstatesDbSet.Object);

            this.Setup(c => c.Set<User>()).Returns(UsersDbSet.Object);
            this.Setup(c => c.Users).Returns(UsersDbSet.Object);
        }

        private void GenerateTestData()
        {
            Comments = new List<Comment>()
            {
                new Comment() { Id = 1, User = new User() { Id = 1, UserName = "abc"}, 
                    TimeOfCreation = new DateTime(2020, 07, 22),
                    RealEstateInQuestion = new RealEstate() { Id = 1}},
                new Comment() { Id = 1, User = new User() { Id = 2, UserName = "qwerty" }, 
                    TimeOfCreation = new DateTime(2020, 07, 22),
                    RealEstateInQuestion = new RealEstate() { Id = 2}},
            };

            Pictures = new List<Picture>()
            {
                new Picture() { Id = 1, Url =  "http://abc.img", RealEstateId = 1 },
                new Picture() { Id = 2, Url = "http://defg.img", RealEstateId = 2},
            };

            Ratings = new List<Rating>()
            {
                new Rating() { Id = 1, Score = 3, RatingUser = new User() { Id = 1},
                RatedUser = new User() { Id = 2 }},
                new Rating() { Id = 2, Score = 2, RatingUser = new User() { Id = 2},
                RatedUser = new User() { Id = 1 }}
            };

            RealEstates = new List<RealEstate>()
            {
                new RealEstate() { Id = 1, Pictures = new List<Picture>(),
                    User = new User(), Comments = new List<Comment>(),
                    DateOfAdvertCreation = new DateTime(2020, 07, 30) },
                new RealEstate() { Id = 2, Pictures = new List<Picture>(),
                    User = new User(), Comments = new List<Comment>(),
                    DateOfAdvertCreation = new DateTime(2020, 09, 30) },
            };

            Users = new List<User>()
            {
                new User() { Id = 1, UserName = "Hello", PasswordHash = "NotAHash" },
                new User() { Id = 2, UserName = "Nope", PasswordHash = "NotAHash" },
            };
        }
    }
}
