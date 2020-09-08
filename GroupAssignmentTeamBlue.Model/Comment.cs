using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupAssignmentTeamBlue.Model
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Content { get; set; }
        [Required]
        public DateTime TimeOfCreation { get; set; }
        public Comment ParentComment { get; set; }
    }
}
