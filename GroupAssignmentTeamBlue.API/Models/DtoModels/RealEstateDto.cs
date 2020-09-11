﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class RealEstateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // Street name and number
        public string Address { get; set; }
        // Phone number
        public string Contact { get; set; }
        public string Type { get; set; }
        public decimal Rent { get; set; }
        public decimal SellPrice { get; set; }
        public string YearBuilt { get; set; }
    }
}