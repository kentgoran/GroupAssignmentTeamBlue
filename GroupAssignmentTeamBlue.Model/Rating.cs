using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroupAssignmentTeamBlue.Model
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public User RatedUser { get; set; }
        [Required]
        public User RatingUser { get; set; }
        [Required]
        [Range(1,5)]
        public int Score { get; set; }
    }
}
