using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.API.ValidationAttributes;
using GroupAssignmentTeamBlue.Model.Enums;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests
{
    public class HasToBeForeSaleOrRentableAttributeTests
    {
        // Arrange
        private readonly HasToBeForSaleOrRentable validationAttribute = new HasToBeForSaleOrRentable();
        private readonly RealEstateForCreationDto hasRentingPrice = new RealEstateForCreationDto()
        {
            Title = "",
            Description = "",
            Contact = "",
            Address = "",
            Type = EstateType.Apartment,
            RentingPrice = 1,
            SellingPrice = null,
            ConstructionYear = 0
        };
        private readonly RealEstateForCreationDto hasSellingPrice = new RealEstateForCreationDto()
        {
            Title = "",
            Description = "",
            Contact = "",
            Address = "",
            Type = EstateType.Apartment,
            RentingPrice = null,
            SellingPrice = 1,
            ConstructionYear = 0
        };
        private readonly RealEstateForCreationDto hasNoPrice = new RealEstateForCreationDto()
        {
            Title = "",
            Description = "",
            Contact = "",
            Address = "",
            Type = EstateType.Apartment,
            RentingPrice = null,
            SellingPrice = null,
            ConstructionYear = 0
        };

        [Fact]
        public void IsValid_IsRentable_ShouldBeValid()
        {
            // Act
            var isValid = validationAttribute.IsValid(hasRentingPrice);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void IsValid_IsSellable_ShouldBeValid()
        {
            // Act
            var isValid = validationAttribute.IsValid(hasSellingPrice);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void IsValid_IsNotSellableNorRentAble_ShouldBeInvalid()
        {
            // Act
            var isValid = validationAttribute.IsValid(hasNoPrice);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void IsValid_NonRealEstateObject_ShouldBeInvalid()
        {
            // Act
            var isValid = validationAttribute.IsValid(2);

            // Assert
            Assert.False(isValid);
        }
    }
}
