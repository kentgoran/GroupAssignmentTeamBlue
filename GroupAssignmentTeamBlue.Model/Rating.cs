using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroupAssignmentTeamBlue.Model
{
    public class Rating : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RatedUserId")]
        public User RatedUser { get; set; }
        [Required]
        public int RatedUserId { get; set; }
       
        [ForeignKey("RatingUserId")]
        public User RatingUser { get; set; }
        [Required]
        public int RatingUserId { get; set; }
        [Required]
        [Range(1,5)]
        public int Score { get; set; }
    }
}
