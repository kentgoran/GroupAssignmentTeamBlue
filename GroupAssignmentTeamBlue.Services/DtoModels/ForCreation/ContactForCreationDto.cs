﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class ContactForCreationDto
    {
        [Required(ErrorMessage = "A {0} is required")]
        [MaxLength(50, ErrorMessage = "The name cannot be longer than {1} characters")]
        // Min length?
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
