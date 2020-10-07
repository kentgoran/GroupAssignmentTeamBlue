using FluentAssertions;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories.Child_Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class PictureRepositoryTests
    {
        private readonly AdvertContext context;
        private readonly PictureRepository repo;
        private readonly List<Picture> testPictures = new List<Picture>()
        {
            new Picture() { Id = 1, Url =  "http://abc.img", RealEstateId = 1 },
            new Picture() { Id = 2, Url = "http://defg.img", RealEstateId = 2}
        };
        private MockedDbSet<Picture> dbSetPictureMock;

        public PictureRepositoryTests()
        {
            // Arrange
            dbSetPictureMock = new MockedDbSet<Picture>(testPictures);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<Picture>()).Returns(() => dbSetPictureMock.Object);
            contextMock.Setup(c => c.Find<Picture>()).Returns(dbSetPictureMock.Object.Find());
            contextMock.Setup(c => c.Pictures).Returns(() => dbSetPictureMock.Object);


            repo = new PictureRepository(contextMock.Object);
        }

        [Fact]
        public void Get_ExistsingId_ShouldGetPicture()
        {
            int id = testPictures.First().Id;
            var expectedPic = testPictures.First();
            
            dbSetPictureMock.Setup(ds => ds.Find(It.IsAny<int>())).Returns(dbSetPictureMock.FindEntity(id));

            // Act
            var picture = repo.Get(id);

            // Assert
            picture.Should().BeEquivalentTo(expectedPic);
            picture.Should().Be(expectedPic);

        }

        public Picture FindPicture(List<Picture> pictures)
        {
            return pictures.Find(p => p.Id == 1);
        }
    }
}
