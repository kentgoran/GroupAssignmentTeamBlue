using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(AdvertContext context) : base(context)
        {
        }
        

        public ICollection<Comment> GetCommentsForRealEstate(int realEstateId, int skip, int take)
        {
            return context.Comments.Where(c => c.RealEstateInQuestion.Id == realEstateId).Skip(skip).Take(take).Include(c => c.User).ToList();
        }
    }
}
