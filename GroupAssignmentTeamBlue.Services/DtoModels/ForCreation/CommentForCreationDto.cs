using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels.ForCreation
{
    public class CommentForCreationDto
    {
        [Required(ErrorMessage = "A {0} is required")]
        public UserDto User { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(1500, ErrorMessage = "The content cannot be longer than {1} characters")]
        public string Content { get; set; }
        public CommentDto ParentComment { get; set; }
    }
}
