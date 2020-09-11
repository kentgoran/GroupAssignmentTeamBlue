using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupAssignmentTeamBlue.API.Models.DtoModels
{
    public class UserDto
    {
        public string UserName { get; set; }
        public int RealEstateCount { get; set; }
        public int CommentCount { get; set; }
        public int RatingAvrage { get; set; }
    }
}
