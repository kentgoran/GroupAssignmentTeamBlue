using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// A Real Estate Dto with full details
    /// </summary>
    public class RealEstateFullDetailDto : RealEstateDto
    {
        /// <summary>
        /// City from where the RealEstate is
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Amount of square meters
        /// </summary>
        public int SquareMeters { get; set; }
        /// <summary>
        /// Amount of rooms
        /// </summary>
        public int Rooms { get; set; }
        /// <summary>
        /// Name of the user who created the listing
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// List of comments made about the object
        /// </summary>
        public IEnumerable<CommentDto> Comments { get; set; }
        /// <summary>
        /// Urls to pictures
        /// </summary>
        public IEnumerable<PictureDto> Urls { get; set; }

    }
}
