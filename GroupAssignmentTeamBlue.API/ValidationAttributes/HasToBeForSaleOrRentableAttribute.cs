using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.ValidationAttributes
{
    public class HasToBeForSaleOrRentable : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try 
            {
                var realEstate = value as RealEstateForCreationDto;

                // If the realestate is neither sellable nor rentable,
                // return error message
                if (realEstate.SellPrice == null && realEstate.Rent == null)
                {
                    return new ValidationResult(ErrorMessage,
                        new[] { nameof(RealEstateForCreationDto) });
                }

                return ValidationResult.Success;
            }
            catch(Exception ex)
            {
                return new ValidationResult(ex.Message, 
                    new[] { nameof(RealEstateForCreationDto) });
            }
        }


    }
}
