using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    /// <summary>
    /// A Rating for creation, with Username and a Value
    /// </summary>
    public class RatingForCreationDto
    {
        /// <summary>
        /// Username of the user being rated
        /// </summary>
        [Required(ErrorMessage = "A {0} is required")]
        public string UserName { get; set; }
        /// <summary>
        /// Value, the score to give, between 1-5
        /// </summary>
        [Required(ErrorMessage = "A {0} is required")]
        [Range(1, 5)]
        public int Value { get; set; }
    }
}
