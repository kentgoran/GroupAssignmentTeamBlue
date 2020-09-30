using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models
{
    /// <summary>
    /// Model only used for modelling in swagger
    /// </summary>
    public class JwtTokenModel
    {
        /// <summary>
        /// The actual token
        /// </summary>
        public string Access_Token { get; set; }
        /// <summary>
        /// Type of token
        /// </summary>
        public string Token_Type { get; set; }
        /// <summary>
        /// Seconds until expiration
        /// </summary>
        public int Expires_In { get; set; }
        /// <summary>
        /// a users name
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Time of issuing
        /// </summary>
        public DateTime Issued { get; set; }
        /// <summary>
        /// Time of expiration
        /// </summary>
        public DateTime Expires { get; set; }
    }
}
