using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RatingForCreationDto
    {
        [Required]
        public UserDto RatedUser { get; set; }
        [Required]
        public UserDto RatingUser { get; set; }
        [Required]
        [Range(1, 5)]
        public int Score { get; set; }
    }
}
