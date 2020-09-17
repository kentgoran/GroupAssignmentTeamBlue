using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.Tests.Unittests
{
    public class UserServicesUnitTests
    {
        private HttpClient _client;

        public UserServicesUnitTests()
        {

            _client = new HttpClient();
        }


        // Tests for status codes??

        #region GetUserTests
        [Fact]
        public void GetUser_ValidUser_ShouldCreateUser()
        {
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void GetUser_InvalidUser_ShouldNotCreateUser()
        {
            // Arrange
            // Act
            // Assert
        }
        #endregion

        #region RateUserTests
        [Fact]
        public void RateUser_ValidRating_ShouldCreateRating()
        {
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void RateUser_UnExistingRatedUser_ShouldReturn400()
        {
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void RateUser_RatingScoreOutOfAllowedRange_ShouldNotCreateRating()
        {
            // Arrange
            // Act
            // Assert
        }
        #endregion
    }
}
