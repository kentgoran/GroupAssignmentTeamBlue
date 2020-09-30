using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    /// <summary>
    /// A comment for creation, with RealEstateId and Content
    /// </summary>
    public class CommentForCreationDto
    {
        /// <summary>
        /// Id of the RealEstate in question
        /// </summary>
        [Required(ErrorMessage = "A {0} is required")]
        public int RealEstateId { get; set; }
        /// <summary>
        /// The actual comment
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(1500, ErrorMessage = "The content cannot be longer than {1} characters")]
        public string Content { get; set; }
    }
}
