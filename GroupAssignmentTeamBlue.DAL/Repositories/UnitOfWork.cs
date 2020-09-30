using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.DAL.Repositories.Child_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Context
{
    public class UnitOfWork
    {
        private readonly AdvertContext context;
        public UnitOfWork(AdvertContext context)
        {
            this.context = context;
            
            CommentRepository = new CommentRepository(context);
            RatingRepository = new RatingRepository(context);
            RealEstateRepository = new RealEstateRepository(context);
            UserRepository = new UserRepository(context);
            PictureRepository = new PictureRepository(context);

        }
        public CommentRepository CommentRepository { get; private set; }
        public RatingRepository RatingRepository { get; private set; }
        public RealEstateRepository RealEstateRepository { get; private set; }
        public UserRepository UserRepository { get; private set; }
        public PictureRepository PictureRepository { get; set; }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
