using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class RealEstateDetailsDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
        public AddressDto Address { get; set; }
        public string Type { get; set; }
        public bool IsRentable { get; set; }
        public bool IsSellable { get; set; }
        public decimal Rent { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime YearBuilt { get; set; }
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
