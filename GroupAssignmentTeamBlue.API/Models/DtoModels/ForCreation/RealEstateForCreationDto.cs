using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation
{
    public class RealEstateForCreationDto
    {
        [Required(ErrorMessage = "A {0} is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A {0} is required")]
        public string Description { get; set; }
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

        public int YearBuilt { get; set; }
    }
}
