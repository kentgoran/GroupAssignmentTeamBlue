using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.API.ValidationAttributes;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests
{
    public class HasToBeForeSaleOrRentableAttributeTests
    {
        private readonly HasToBeForSaleOrRentable validationAttribute = new HasToBeForSaleOrRentable();

        [Fact]
        public void IsValid_IsRentable_ShouldBeValid()
        {
            var isValid = validationAttribute.IsValid(new RealEstateForCreationDto() 
                { Title = "", Description = "", Contact = "", Address = "", 
                Type = EstateType.Apartment, RentingPrice = 1, SellingPrice = null, 
                ConstructionYear = 0 });

            Assert.True(isValid);
        }

        [Fact]
        public void IsValid_IsSellable_ShouldBeValid()
        {
            var isValid = validationAttribute.IsValid(new RealEstateForCreationDto()
            {
                Title = "",
                Description = "",
                Contact = "",
                Address = "",
                Type = EstateType.Apartment,
                RentingPrice = null,
                SellingPrice = 1,
                ConstructionYear = 0
            });

            Assert.True(isValid);
        }

        [Fact]
        public void IsValid_IsNotSellableNorRentAble_ShouldBeInvalid()
        {
            var isValid = validationAttribute.IsValid(new RealEstateForCreationDto()
            {
                Title = "",
                Description = "",
                Contact = "",
                Address = "",
                Type = EstateType.Apartment,
                RentingPrice = null,
                SellingPrice = null,
                ConstructionYear = 0
            });

            Assert.False(isValid);
        }

        [Fact]
        public void IsValid_NonRealEstateObject_ShouldBeInvalid()
        {
            var isValid = validationAttribute.IsValid(2);

            Assert.False(isValid);
        }
    }
}
