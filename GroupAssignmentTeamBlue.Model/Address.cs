using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace GroupAssignmentTeamBlue.Model
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string StreetName { get; set; }
        [Required]
        [MaxLength(10)]
        public string StreetNumber { get; set; }
        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string StateProvince { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
    }
}
