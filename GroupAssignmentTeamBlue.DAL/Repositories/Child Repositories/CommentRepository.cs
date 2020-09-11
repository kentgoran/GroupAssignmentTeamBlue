using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
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
        //public ICollection<Comment> GetCommentsByUser(int userId)
        //{
        //    return context.Comments
        //        .Include(c => c.User)
        //        .Where(c => c.User.Id == userId)
        //        .ToList();
        //}
    }
}
