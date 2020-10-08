using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using FluentAssertions;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class RealEstateRepositoryTests
    {
        private readonly RealEstateRepository repo;
        private readonly List<RealEstate> testRealEstates = new List<RealEstate>()
        {
            new RealEstate() { Id = 1, Pictures = new List<Picture>(),
                User = new User(), Comments = new List<Comment>(),
                DateOfAdvertCreation = new DateTime(2020, 07, 30) },
            new RealEstate() { Id = 2, Pictures = new List<Picture>(),
                User = new User(), Comments = new List<Comment>(),
                DateOfAdvertCreation = new DateTime(2020, 09, 30) },
            new RealEstate() { Id = 3, Pictures = new List<Picture>(), 
                User = new User(), Comments = new List<Comment>(),
                DateOfAdvertCreation = new DateTime(2020, 06, 30) }
        };
        private MockedDbSet<RealEstate> dbSetRealEstateMock;

        public RealEstateRepositoryTests()
        {
            // Arrange
            dbSetRealEstateMock = new MockedDbSet<RealEstate>(testRealEstates);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<RealEstate>()).Returns(dbSetRealEstateMock.Object);
            contextMock.Setup(c => c.RealEstates).Returns(dbSetRealEstateMock.Object);

            repo = new RealEstateRepository(contextMock.Object);
        }

        [Fact]
        public void Add_ShouldCallAdd_ShouldAddRealEstate()
        {
            // Arrange
            var rating = new RealEstate()
            {
                Id = 3,
                Pictures = new List<Picture>(),
                User = new User(),
                Comments = new List<Comment>(),
                DateOfAdvertCreation = new DateTime(2020, 04, 30)
            };

            dbSetRealEstateMock
                .Setup(ds => ds.Add(It.IsAny<RealEstate>()))
                .Callback<RealEstate>(testRealEstates.Add);

            // Act
            repo.Add(rating);

            // Assert
            testRealEstates.Should().Contain(rating);
            dbSetRealEstateMock.Verify(ds => ds.Add(It.IsAny<RealEstate>()), Times.Exactly(1));

            // Clean up
            testRealEstates.Remove(rating);
            
        }

        [Fact]
        public void Remove_ShouldCallRemove_ShouldRemoveRealEstate()
        {
            // Arrange
            var realEstateToRemove = testRealEstates.Last();

            dbSetRealEstateMock
                .Setup(ds => ds.Remove(It.IsAny<RealEstate>()))
                .Callback<RealEstate>(RemoveRealEstate);

            // Act
            repo.Remove(realEstateToRemove);

            // Assert
            testRealEstates.Should().NotContain(realEstateToRemove);
            dbSetRealEstateMock.Verify(ds => ds.Remove(It.IsAny<RealEstate>()), Times.Exactly(1));
            testRealEstates.Add(realEstateToRemove);
        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnRealEstate()
        {
            // Arrange
            int id = testRealEstates.First().Id;
            var expectedRealEstate = testRealEstates.First();
            dbSetRealEstateMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindRealEstate(id));

            // Act
            var realEstate = repo.Get(id);

            // Assert
            realEstate.Should().BeEquivalentTo(expectedRealEstate);
        }

        [Fact]
        public void GetAll_ShouldGetAll()
        {
            // Act
            var realEstates = repo.GetAll();

            // Assert
            realEstates.Should().BeEquivalentTo(testRealEstates);
        }

        [Fact]
        public void SkipAndTakeRealEstates_ShouldSkipAndTake_ShouldReturnRealEstates()
        {
            // Arrange
            int skip = 1;
            int take = 2;
            var expectedRealEstates = testRealEstates
                .OrderByDescending(r => r.DateOfAdvertCreation)
                .Skip(skip).Take(take);

            // Act
            var realEstates = repo.SkipAndTakeRealEstates(skip, take);

            // Assert
            realEstates.Should().BeEquivalentTo(expectedRealEstates);
        }

        [Fact]
        public void GetWithIncludes_ShouldGetRealEstateWithIncludes()
        {
            // Arrange
            var expectedRealEstate = testRealEstates.Last();
            int realEstateId = expectedRealEstate.Id;

            // Act
            var realEstate = repo.GetWithIncludes(realEstateId);

            // Arrange
            realEstate.Should().BeEquivalentTo(expectedRealEstate);
        }

        [Fact]
        public void EntityExists_ExistingEntity_ShouldReturnTrue()
        {
            // Arrange
            int id = testRealEstates.First().Id;
            dbSetRealEstateMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindRealEstate(id));

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
            dbSetRealEstateMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindRealEstate(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeFalse();
        }

        private RealEstate FindRealEstate(int id)
        {
            return testRealEstates.Find(p => p.Id == id);
        }

        private void RemoveRealEstate(RealEstate realEstate)
        {
            testRealEstates.Remove(realEstate);
        }
    }
}
