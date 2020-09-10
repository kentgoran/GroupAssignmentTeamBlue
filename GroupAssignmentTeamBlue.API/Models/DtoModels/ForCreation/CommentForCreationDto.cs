using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class CommentForCreationDto
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public UserForCreationDto User { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Content { get; set; }
        [Required]
        public DateTime TimeOfCreation { get; set; }
        public CommentDto ParentComment { get; set; }
    }
}
