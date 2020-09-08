using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RatingForCreationDto
    {
        // Kommer från URL??
        [Required(ErrorMessage ="An id of the rated user is required")]
        public Guid RatedUserId { get; set; }
        [Required(ErrorMessage = "An id of the rating user is required")]
        public Guid RatingUserId { get; set; }
        [Required(ErrorMessage = "A street name is required")]
        [Range(1, 5)]
        public int Score { get; set; }
    }
}
