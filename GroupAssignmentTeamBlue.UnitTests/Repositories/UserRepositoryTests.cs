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
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class UserRepositoryTests
    {
        private readonly UserRepository repo;
        private readonly List<User> testUsers = new List<User>()
        {
            new User() { Id = 1, UserName = "a" },
            new User() { Id = 2, UserName = "b" },
            new User() { Id = 3, UserName = "c" }
        };
        private MockedDbSet<User> dbSetUserMock;

        public UserRepositoryTests()
        {
            // Arrange
            dbSetUserMock = new MockedDbSet<User>(testUsers);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<User>()).Returns(dbSetUserMock.Object);
            contextMock.Setup(c => c.Users).Returns(dbSetUserMock.Object);

            repo = new UserRepository(contextMock.Object);
        }

        [Fact]
        public void Add_ShouldCallAdd_ShouldAddUser()
        {
            // Arrange
            var user = new User()
            {
                Id = 3,
                UserName = "NewUser"
            };

            dbSetUserMock
                .Setup(ds => ds.Add(It.IsAny<User>()))
                .Callback<User>(testUsers.Add);

            // Act
            repo.Add(user);

            // Assert
            testUsers.Should().Contain(user);

            // Clean up
            testUsers.Remove(user);
        }

        [Fact]
        public void Remove_ShouldCallRemove_ShouldRemoveUser()
        {
            // Arrange
            var userToRemove = testUsers.Last();

            dbSetUserMock
                .Setup(ds => ds.Remove(It.IsAny<User>()))
                .Callback<User>(RemoveUser);

            // Act
            repo.Remove(userToRemove);

            // Assert
            testUsers.Should().NotContain(userToRemove);
            testUsers.Add(userToRemove);
        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnUser()
        {
            // Arrange
            int id = testUsers.First().Id;
            var expectedUser = testUsers.First();
            dbSetUserMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindUser(id));

            // Act
            var user = repo.Get(id);

            // Assert
            user.Should().BeEquivalentTo(expectedUser);
        }

        [Fact]
        public void GetAll_ShouldGetAll()
        {
            // Act
            var users = repo.GetAll();

            // Assert
            users.Should().BeEquivalentTo(testUsers);
        }

        [Fact]
        public void EntityExists_ExistingEntity_ShouldReturnTrue()
        {
            // Arrange
            int id = testUsers.First().Id;
            dbSetUserMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindUser(id));

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
            dbSetUserMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindUser(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeFalse();
        }

        private User FindUser(int id)
        {
            return testUsers.Find(p => p.Id == id);
        }

        private void RemoveUser(User user)
        {
            testUsers.Remove(user);
        }
    }
}
