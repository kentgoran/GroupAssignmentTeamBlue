using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// Real Estate dto, partly detailed
    /// </summary>
    public class RealEstatePartlyDetailedDto
    {
        /// <summary>
        /// Id of the realEstate
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the object
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// How much the rent is, per month
        /// </summary>
        public decimal? Rent { get; set; }
        /// <summary>
        /// How much to buy the object
        /// </summary>
        public decimal? SellPrice { get; set; }
        /// <summary>
        /// Boolean depicting whether the place is for rent or not
        /// </summary>
        public bool IsRentable { get; set; }
        /// <summary>
        /// Boolean depicting whether the place is for sale or not
        /// </summary>
        public bool IsSellable { get; set; }
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
        public int RealEstateType { get; set; }
        /// <summary>
        /// The year the object was built
        /// </summary>
        public int ConstructionYear { get; set; }
        /// <summary>
        /// Date and time of advert creating
        /// </summary>
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
