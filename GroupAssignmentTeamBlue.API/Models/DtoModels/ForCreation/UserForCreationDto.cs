using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class UserForCreationDto
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be between 3 and 30 characters")]
        [MaxLength(30, ErrorMessage = "Username must be between 3 and 30 characters")]
                          // vv Dots are not allowed
        //[RegularExpression("^[^.]$", ErrorMessage ="The Username should not contain any dots")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "An email address is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A password is required")]
        //Regex checks atleast 1 lowercase, 1 uppercase, 1 digit and atleast 6 total
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$", ErrorMessage = "Password must contain atleast 1 uppercase letter, 1 lowercase letter, 1 digit and be atleast 6 digits long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
