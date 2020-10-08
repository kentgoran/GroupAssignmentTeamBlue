using AutoMapper;
using FluentAssertions;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Controllers
{
    public class CommentControllerTests
    {
        private readonly CommentController controller;
        private Mock<UserManager<User>> managerMock;
        private MockedContext mockedContext;
        private IMapper mapper;

        public CommentControllerTests()
        {

            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile(typeof(CommentProfile));
            });
            mapper = new Mapper(config);

            var userStore = new Mock<IUserStore<User>>();
            var hasher = new Mock<IPasswordHasher<User>>();
            managerMock = new Mock<UserManager<User>>(
                userStore.Object, null, hasher.Object, null, null, null, null, null, null);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            mockedContext = new MockedContext(builder.Options);


            controller = new CommentController(mapper, mockedContext.Object, managerMock.Object);
        }

        [Fact]
        public void GetComments_ShouldGetComment()
        {
            // Arrange
            int realEstateId = mockedContext.Comments.First().RealEstateInQuestion.Id;
            var testComments = mockedContext.Comments.Where(c => c.RealEstateInQuestion.Id == realEstateId);
            var expectedComments = mapper.Map<List<CommentDto>>(testComments);
            mockedContext.RealEstatesDbSet.Setup(ds => ds.Find(It.IsAny<int>())).Returns(FindRealEstate(realEstateId));

            // Act
            var comments = controller.GetComment(realEstateId, 0, testComments.Count());

            // Assert
            comments.Should().BeEquivalentTo(new OkObjectResult(expectedComments));
        }

        private Comment FindComment(int id)
        {
            return mockedContext.Comments.Find(p => p.Id == id);
        }

        private RealEstate FindRealEstate(int id)
        {
            return mockedContext.RealEstates.Find(p => p.Id == id);
        }
    }
}
