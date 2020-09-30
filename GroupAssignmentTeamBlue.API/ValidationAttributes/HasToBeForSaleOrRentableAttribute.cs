using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.ValidationAttributes
{
    /// <summary>
    /// Checks so that a given RealEstateForCreationDto has either a sellingprice or a rentprice
    /// </summary>
    public class HasToBeForSaleOrRentable : ValidationAttribute
    {
        /// <summary>
        /// Validates the rule
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try 
            {
                var realEstate = value as RealEstateForCreationDto;

                // If the realestate is neither sellable nor rentable,
                // return error message
                if (realEstate.SellingPrice == null && realEstate.RentingPrice == null)
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
