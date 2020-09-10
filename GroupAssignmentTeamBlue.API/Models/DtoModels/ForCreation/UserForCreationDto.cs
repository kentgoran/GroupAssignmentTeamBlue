using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class UserForCreationDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be between 3 and 20 characters")]
        [MaxLength(20, ErrorMessage = "Username must be between 3 and 20 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "An email address is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A password is required")]
        [MinLength(3, ErrorMessage = "The password has to be atleast 3 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
