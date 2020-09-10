using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class CommentForCreationDto
    {
        // User kommer från URL
        // Potensiell parent comment kommer från URL
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(1500, ErrorMessage = "The content cannot be longer than {1} characters")]
        public string Content { get; set; }
    }
}
