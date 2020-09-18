using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// Real Estate dto, partly detailed
    /// </summary>
    public class RealEstatePartlyDetailedDto : RealEstateDto
    {
        /// <summary>
        /// Objects description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Address of the object
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The year the object was built
        /// </summary>
        public int YearBuilt { get; set; }
        /// <summary>
        /// Date and time of advert creating
        /// </summary>
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
