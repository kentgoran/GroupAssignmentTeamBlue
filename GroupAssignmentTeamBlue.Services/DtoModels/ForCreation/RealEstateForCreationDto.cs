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
        [Required]
        public Guid Id { get; set; }
        [Required]
        public UserForCreationDto User { get; set; }
        [Required]
        public ContactForCreationDto Contact { get; set; }
        [Required]
        public AddressForCreationDto Address { get; set; }
        [Required]
        public EstateType Type { get; set; }
        [Required]
        public bool IsRentable { get; set; }
        [Required]
        public bool IsSellable { get; set; }
        [DataType(DataType.Currency)]
        public decimal Rent { get; set; }
        [DataType(DataType.Currency)]
        public decimal SellPrice { get; set; }
        public DateTime YearBuilt { get; set; }
        [Required]
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
