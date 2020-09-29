using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AdvertContext context) : base(context) 
        {
        }

        public User Get(string userName)
        {
            return context.Users
                .Where(u => u.UserName == userName)
                .Include(u => u.Comments)
                .Include(u => u.RatingsRecieved)
                .Include(u => u.RealEstates)
                .FirstOrDefault();
        }
    }
}
