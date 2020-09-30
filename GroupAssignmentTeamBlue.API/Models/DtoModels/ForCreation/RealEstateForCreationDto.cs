using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using GroupAssignmentTeamBlue.API.ValidationAttributes;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    /// <summary>
    /// A RealEstate for creation
    /// </summary>
    [HasToBeForSaleOrRentable(ErrorMessage = "The real estate has to either be for sale or rentable")]
    public class RealEstateForCreationDto
    {
        /// <summary>
        /// Title of the advert
        /// </summary>
        [Required(ErrorMessage = "A {0} is required")]
        public string Title { get; set; }
        /// <summary>
        /// A description of the place
        /// </summary>
        [Required(ErrorMessage = "A {0} is required")]
        public string Description { get; set; }
        /// <summary>
        /// Contact info, ie email/phone number
        /// </summary>
        [Required(ErrorMessage = "A {0} is required")]
        public string Contact { get; set; }
        /// <summary>
        /// Address of the place
        /// </summary>

        [Required(ErrorMessage = "An {0} is required")]
        public string Address { get; set; }
        /// <summary>
        /// The type of estate, Apartment, House, Office or Warehouse
        /// </summary>

        [Required(ErrorMessage = "An Estate {0} is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EstateType Type { get; set; }
        /// <summary>
        /// RentingPrice, nullable. However, either RentingPrice or SellingPrice has to be entered
        /// </summary>

        [DataType(DataType.Currency)]
        public decimal? RentingPrice { get; set; }
        /// <summary>
        /// SellingPrice, nullable. However, either RentingPrice or SellingPrice has to be entered
        /// </summary>

        [DataType(DataType.Currency)]
        public decimal? SellingPrice { get; set; }
        /// <summary>
        /// The year the place was built
        /// </summary>

        public int ConstructionYear { get; set; }
        /// <summary>
        /// Primary pictures url
        /// </summary>
        [Required(ErrorMessage ="A {0} is required.")]
        [Url]
        public string ListingUrl { get; set; }
        /// <summary>
        /// City in question
        /// </summary>
        [Required(ErrorMessage ="An {0} is required.")]
        public string City { get; set; }
        /// <summary>
        /// Square meters for given listing
        /// </summary>
        [Required(ErrorMessage = "{0} is required.")]
        [Range(5,5000, ErrorMessage ="SquareMeters must be in range 5-5000")]
        public int SquareMeters { get; set; }
        /// <summary>
        /// Amount of rooms, range of 1-50
        /// </summary>
        [Required(ErrorMessage = "{0} is required.")]
        [Range(1,50, ErrorMessage ="Amount of rooms must be in range 1-50")]
        public int Rooms { get; set; }
        /// <summary>
        /// Optional, additional pictures for given realEstate
        /// </summary>
        [ListOfUrlsValidateAll(ErrorMessage = "All given urls must be actual urls")]
        public IEnumerable<string> Urls { get; set; }
    }
}
