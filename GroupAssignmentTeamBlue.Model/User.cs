using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupAssignmentTeamBlue.Model
{
    public class User : IdentityUser<int>
    {
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Rating> RatingsMade { get; set; }
        public IEnumerable<Rating> RatingsRecieved { get; set; }
        public IEnumerable<RealEstate> RealEstates { get; set; }

    }
}
