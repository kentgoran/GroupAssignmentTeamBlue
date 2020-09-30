using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GroupAssignmentTeamBlue.Model
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        [Url]
        public string Url { get; set; }
        [Required]
        public int RealEstateId { get; set; }
    }
}
