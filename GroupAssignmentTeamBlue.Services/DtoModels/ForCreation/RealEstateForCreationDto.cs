using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RealEstateForCreationDto
    {
        // Kommer från URL??
        [Required(ErrorMessage = "An id of the user is required")]
        public Guid UserId { get; set; }
        
        // Om kontakten redan finns??
        [Required(ErrorMessage = "A {0} is required")]
        public ContactForCreationDto Contact { get; set; }
        
        // Om Addressen redan finns??
        [Required(ErrorMessage = "An {0} is required")]
        public AddressForCreationDto Address { get; set; }
        
        [Required(ErrorMessage = "An Estate {0} is required")]
        public EstateType Type { get; set; }
        
        [Required(ErrorMessage = "A retable status required")]
        public bool IsRentable { get; set; }
        
        [Required(ErrorMessage = "A sellable status required")]
        public bool IsSellable { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Rent { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal SellPrice { get; set; }
        
        public DateTime YearBuilt { get; set; }
    }
}
