﻿using AutoMapper.Configuration.Annotations;
using GroupAssignmentTeamBlue.Model.Enums;
using GroupAssignmentTeamBlue.Services.Profiles;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.DtoModels
{
    public class RealEstateForCreationDto
    {
        // User kommer från Token
        [Required(ErrorMessage = "A {0} is required")]
        public ContactForCreationDto Contact { get; set; }
        
        [Required(ErrorMessage = "An {0} is required")]
        public AddressForCreationDto Address { get; set; }
        
        [Required(ErrorMessage = "An Estate {0} is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EstateType Type { get; set; }
        
        [Required(ErrorMessage = "A retable status required")]
        [JsonConverter(typeof(BoolToStringConverter))]
        public bool IsRentable { get; set; }
        
        [Required(ErrorMessage = "A sellable status required")]
        [JsonConverter(typeof(BoolToStringConverter))]
        public bool IsSellable { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Rent { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal SellPrice { get; set; }
        
        public DateTime YearBuilt { get; set; }
    }
}
