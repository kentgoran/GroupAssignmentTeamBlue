using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    /// <summary>
    /// User dto, with username, amount of realEstates listed, amount of comments and an average rating recieved
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Amount of realEstates listed
        /// </summary>
        public int RealEstateCount { get; set; }
        /// <summary>
        /// Amount of comments made
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// Average rating recieved
        /// </summary>
        public int RatingAvrage { get; set; }
    }
}
