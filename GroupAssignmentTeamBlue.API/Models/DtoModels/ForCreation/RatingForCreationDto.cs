using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class RatingForCreationDto
    {
        [Required(ErrorMessage = "A {0} is required")]
        public int RatedUserId { get; set; }
        // Rated User kommer från URL och Rating user kommer från token
        [Required(ErrorMessage = "A {0} is required")]
        [Range(1, 5)]
        public int Score { get; set; }
    }
}
