using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// RealEstate dto, with id-number, title, rent, sellprice and bools for isRentable and isSellable
    /// </summary>
    public class RealEstateDto
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
    }
}
