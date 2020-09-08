using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GroupAssignmentTeamBlue.Model
{
    public class RealEstate
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Contact Contact { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public EstateType Type { get; set; }
        [Required]
        public bool IsRentable { get; set; }
        [Required]
        public bool IsSellable { get; set; }
        [DataType(DataType.Currency)]
        public decimal Rent { get; set; }
        [DataType(DataType.Currency)]
        public decimal SellPrice { get; set; }
        public DateTime YearBuilt { get; set; }
        [Required]
        public DateTime DateOfAdvertCreation { get; set; }
    }
}
