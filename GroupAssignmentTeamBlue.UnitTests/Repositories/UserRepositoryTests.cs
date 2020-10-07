using GroupAssignmentTeamBlue.DAL.Context;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class UserRepositoryTests
    {
        // Mock Context + db
        private readonly Mock<AdvertContext> context;

        public UserRepositoryTests()
        {
        }

        [Fact]
        public void GetUser_ValidId_ShouldGetUser()
        {

        }

        [Fact]
        public void GetUser_InvalidUser_ShouldNotAddUser()
        {

        }
    }
}
