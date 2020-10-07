using GroupAssignmentTeamBlue.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests
{
    public class ListOfUrlsAllMustBeValidateAllTests
    {
        // Arrange
        private readonly ListOfUrlsValidateAll listUrlValidaiton = new ListOfUrlsValidateAll();
        private readonly List<string> validUrls = new List<string>() { "http://catpicture.img", "http://totallyrealurl.img" };
        private readonly List<string> someInvalidUrls = new List<string>() { "ThisIsNotAUrl.com", "nope", "http://actualurl.img" };

        [Fact]
        public void IsValid_ValidUrls_ShouldReturnTrue()
        {
            // Act
            var result = listUrlValidaiton.IsValid(validUrls);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValid_InvalidUrls_ShouldReturnFalseAndError()
        {
            // Act
            var result = listUrlValidaiton.IsValid(someInvalidUrls);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValid_NonStringListObject_ShouldReturnFalseAndError()
        {
            // Act
            var result = listUrlValidaiton.IsValid(2);

            // Assert
            Assert.False(result);
        }
    }
}
