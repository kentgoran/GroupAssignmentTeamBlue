using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RealEstateDto
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public bool IsRentable { get; set; }
        public bool IsSellable { get; set; }
        public decimal Rent { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
