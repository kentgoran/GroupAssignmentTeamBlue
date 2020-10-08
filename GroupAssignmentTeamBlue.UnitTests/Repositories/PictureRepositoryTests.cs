using FluentAssertions;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories.Child_Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class PictureRepositoryTests
    {
        private readonly PictureRepository repo;
        private readonly List<Picture> testPictures = new List<Picture>()
        {
            new Picture() { Id = 1, Url =  "http://abc.img", RealEstateId = 1 },
            new Picture() { Id = 2, Url = "http://defg.img", RealEstateId = 2},
            new Picture() { Id = 3, Url = "http://hij.img", RealEstateId = 2 }
        };
        private MockedDbSet<Picture> dbSetPictureMock;
        private AdvertContext context;

        public PictureRepositoryTests()
        {
            // Arrange
            dbSetPictureMock = new MockedDbSet<Picture>(testPictures);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<Picture>()).Returns(dbSetPictureMock.Object);
            contextMock.Setup(c => c.Pictures).Returns(dbSetPictureMock.Object);

            repo = new PictureRepository(contextMock.Object);
            context = contextMock.Object;
        }

        [Fact]
        public void Add_ShouldCallAdd_ShouldAddPicture()
        {
            // Arrange
            var picture = new Picture() { Id = 4, Url = "http://picture.img", RealEstateId = 6 };

            dbSetPictureMock
                .Setup(ds => ds.Add(It.IsAny<Picture>()))
                .Callback<Picture>(testPictures.Add);

            // Act
            repo.Add(picture);

            // Assert
            testPictures.Should().Contain(picture);

            // Clean up
            testPictures.Remove(picture);
            dbSetPictureMock.Verify(m => m.Add(It.IsAny<Picture>()), Times.Exactly(1));
        }

        [Fact]
        public void RemovePicture_ShouldCallRemove_ShouldRemovePicture()
        {
            // Arrange
            var pictureToRemove = testPictures.Last();

            dbSetPictureMock
                .Setup(ds => ds.Remove(It.IsAny<Picture>()))
                .Callback<Picture>(RemovePicture);

            // Act
            repo.Remove(pictureToRemove);

            // Assert
            testPictures.Should().NotContain(pictureToRemove);
            testPictures.Add(pictureToRemove);
            dbSetPictureMock.Verify(m => m.Remove(It.IsAny<Picture>()), Times.Exactly(1));

        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnPicture()
        {
            // Arrange
            int id = testPictures.First().Id;
            var expectedPic = testPictures.First();
            dbSetPictureMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindPicture(id));

            // Act
            var picture = repo.Get(id);

            // Assert
            picture.Should().BeEquivalentTo(expectedPic);
            dbSetPictureMock.Verify(m => m.Find(It.IsAny<int>()), Times.Exactly(1));
        }

        [Fact]
        public void GetAllPictures_ShouldGetAll()
        {
            // Act
            var pictures = repo.GetAll();

            // Assert
            pictures.Should().BeEquivalentTo(testPictures);
        }

        [Fact]
        public void GetAllPicturesForRealEstate_ShouldGetAllWithSameRealEstateId()
        {
            // Arrange
            int realEstateId = testPictures.Last().RealEstateId;

            // Act
            var pictures = repo.GetAllPicturesForRealEstate(realEstateId);

            // Assert
            pictures.All(p => p.RealEstateId == realEstateId).Should().BeTrue();
        }

        [Fact]
        public void EntityExists_ExistingEntity_ShouldReturnTrue()
        {
            // Arrange
            int id = testPictures.First().Id;
            dbSetPictureMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindPicture(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeTrue();
        }

        [Fact]
        public void EntityExists_UnexistingEntity_ShouldReturnFalse()
        {
            // Arrange
            int id = -1;
            dbSetPictureMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindPicture(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeFalse();
        }

        private Picture FindPicture(int id)
        {
            return testPictures.Find(p => p.Id == id);
        }

        private void RemovePicture(Picture picture)
        {
            testPictures.Remove(picture);
        }
    }
}
