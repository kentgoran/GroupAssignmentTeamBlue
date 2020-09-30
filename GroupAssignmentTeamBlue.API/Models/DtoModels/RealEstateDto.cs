using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// RealEstate dto
    /// </summary>
    public class RealEstateDto : RealEstatePartlyDetailedDto
    {
        /// <summary>
        /// Contact information
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// A listings primary picture url
        /// </summary>
        public string ListingUrl { get; set; }
    }
}
