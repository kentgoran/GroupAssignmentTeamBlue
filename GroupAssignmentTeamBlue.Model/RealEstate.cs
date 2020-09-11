﻿using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(500)]
        public string Description { get; set; }

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
        //Can't set dynamic range (DateTime.Now.Year), so set 2 years from now,
        //so that properties not yet built can be input in the system
        [Range(1600, 2022)]
        public int YearBuilt { get; set; }
        [Required]
        public DateTime DateOfAdvertCreation { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
