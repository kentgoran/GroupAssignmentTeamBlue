using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// A Real Estate Dto without authentication-required details
    /// </summary>
    public class RealEstateNoAuthDetailDto : RealEstateDto
    {
        /// <summary>
        /// Urls to pictures
        /// </summary>
        public IEnumerable<PictureDto> Urls { get; set; }

    }
}
