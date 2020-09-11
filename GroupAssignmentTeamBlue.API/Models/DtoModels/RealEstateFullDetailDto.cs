using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class RealEstateFullDetailDto : RealEstatePartlyDetailedDto
    {
        public ContactDto Contact { get; set; }
        public IEnumerable<CommentDto> Comments { get; set; }
    }
}
