using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
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
        /// List of comments made about the object
        /// </summary>
        public IEnumerable<CommentDto> Comments { get; set; }
    }
}
