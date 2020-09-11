using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class RealEstatePartlyDetailedDto : RealEstateDto
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int YearBuilt { get; set; }
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
