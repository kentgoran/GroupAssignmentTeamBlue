using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// DTO for pictures, only transferring the url
    /// </summary>
    public class PictureDto
    {
        /// <summary>
        /// Url of a given picture
        /// </summary>
        public string Url { get; set; }
    }
}
