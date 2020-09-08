using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroupAssignmentTeamBlue.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<RealEstate> RealEstates { get; set; }

    }
}
