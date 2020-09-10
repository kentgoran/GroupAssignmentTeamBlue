using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class AddressForCreationDto
    {
        [Required(ErrorMessage = "A street name is required")]
        [MaxLength(50, ErrorMessage = "The street name cannot be longer than {1} characters")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "A street number is required")]
        [MaxLength(10, ErrorMessage = "The street number cannot be longer than {1} characters")]
        public string StreetNumber { get; set; }

        [Required(ErrorMessage = "A zip code is required")]
        [MaxLength(10, ErrorMessage = "The zip code cannot be longer than {1} characters")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "A state or province is required")]
        [MaxLength(20, ErrorMessage = "The state or province cannot be longer than {1} characters")]
        public string StateProvince { get; set; }

        [Required(ErrorMessage = "A country is required")]
        [MaxLength(30, ErrorMessage = "The state or province cannot be longer than {1} characters")]
        public string Country { get; set; }
    }
}
