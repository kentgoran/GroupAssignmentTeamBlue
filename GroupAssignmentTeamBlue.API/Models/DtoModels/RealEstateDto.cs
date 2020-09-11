using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class RealEstateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Rent { get; set; }
        public decimal SellPrice { get; set; }
        public bool IsRentable { get; set; }
        public bool IsSellable { get; set; }
    }
}
