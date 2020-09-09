using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RatingForCreationDto
    {
        // Rated User kommer från URL och Rating user kommer från token
        [Required(ErrorMessage = "A {0} is required")]
        [Range(1, 5)]
        public int Score { get; set; }
    }
}
