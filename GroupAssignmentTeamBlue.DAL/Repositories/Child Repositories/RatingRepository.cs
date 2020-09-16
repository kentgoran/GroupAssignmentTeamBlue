using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public class RatingRepository : GenericRepository<Rating>
    {
        public RatingRepository(AdvertContext context) : base(context)
        {
        }

        public Rating Get(int ratedUserId, int ratingUserId)
        {
            return context.Ratings
                .Where(r => r.RatedUser.Id == ratedUserId && r.RatingUser.Id == ratingUserId)
                .FirstOrDefault();
        }
    }
}
