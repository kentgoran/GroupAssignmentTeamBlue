using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    /// <summary>
    /// DTO for creation of a picture
    /// </summary>
    public class PictureForCreationDto
    {
        /// <summary>
        /// Pictures given url
        /// </summary>
        [Url]
        [Required(ErrorMessage = "The url for the picture is required")]
        public string Url { get; set; }
        /// <summary>
        /// Id of given RealEstate from which the picture belongs
        /// </summary>
        [Required(ErrorMessage = "Id of which realEstate the picture belongs to is required")]
        public int RealEstateId { get; set; }
    }
}
