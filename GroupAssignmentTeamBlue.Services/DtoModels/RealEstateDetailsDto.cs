using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RealEstateDetailsDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public ContactDto Contact { get; set; }
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
