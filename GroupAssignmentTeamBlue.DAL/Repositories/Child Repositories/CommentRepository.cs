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
        
        /// <summary>
        /// Gets comments for a given realEstate
        /// </summary>
        /// <param name="realEstateId">Id of given realEstate</param>
        /// <param name="skip">The amount of comments to skip</param>
        /// <param name="take">The amount of comments to take</param>
        /// <returns>an ICollection of comments</returns>
        public ICollection<Comment> GetCommentsForRealEstate(int realEstateId, int skip, int take)
        {
            return context.Comments.Where(c => c.RealEstateInQuestion.Id == realEstateId).
                OrderByDescending(c => c.TimeOfCreation).Skip(skip).Take(take).
                Include(c => c.User).ToList();
        }

        /// <summary>
        /// Gets comments for a given username
        /// </summary>
        /// <param name="username">the username in question</param>
        /// <param name="skip">The amount of comments to skip</param>
        /// <param name="take">The amount of comments to take</param>
        /// <returns>an ICollection of comments</returns>
        public ICollection<Comment> GetCommentsByUser(string username, int skip, int take)
        {
            return context.Comments.Where(c => c.User.UserName == username).
                OrderByDescending(c => c.TimeOfCreation).Skip(skip).Take(take).
                Include(c => c.User).ToList();
        }

        public int GetCommentsByRealEstateCount(int id)
        {
            return context.Comments.Where(c => c.RealEstateId == id).Count();
        }
        public int GetCommentsByUsernameCount(string username)
        {
            return context.Comments.Where(c => c.User.UserName == username).Count();
        }
    }
}
