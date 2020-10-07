using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroupAssignmentTeamBlue.Model
{
    public class RealEstate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public EstateType Type { get; set; }
        [Required]
        public bool IsRentable { get; set; }
        [Required]
        public bool IsSellable { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Rent { get; set; }
        [DataType(DataType.Currency)]
        public decimal? SellPrice { get; set; }
        [Range(1600, 2022)]
        [Column("YearBuilt")]
        public int ConstructionYear { get; set; }
        [Required]
        public DateTime DateOfAdvertCreation { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ListingUrl { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Range(5,5000)]
        public int SquareMeters { get; set; }
        [Required]
        [Range(1,50)]
        public int Rooms { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
