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
                Type = EstateType.Apartment, Rent = 1, SellPrice = null, 
                YearBuilt = 0 });

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
                Rent = null,
                SellPrice = 1,
                YearBuilt = 0
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
                Rent = null,
                SellPrice = null,
                YearBuilt = 0
            });

            Assert.False(isValid);
        }
    }
}
