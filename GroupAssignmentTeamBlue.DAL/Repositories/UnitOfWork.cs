using GroupAssignmentTeamBlue.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Context
{
    public class UnitOfWork
    {
        private AdvertContext context;
        public UnitOfWork(AdvertContext context)
        {
            this.context = context;
            
            AddressRepository = new AddressRepository(context);
            CommentRepository = new CommentRepository(context);
            ContactRepository = new ContactRepository(context);
            RatingRepository = new RatingRepository(context);
            RealEstateRepository = new RealEstateRepository(context);
            UserRepository = new UserRepository(context);

        }
        public AddressRepository AddressRepository { get; private set; }
        public CommentRepository CommentRepository { get; private set; }
        public ContactRepository ContactRepository { get; private set; }
        public RatingRepository RatingRepository { get; private set; }
        public RealEstateRepository RealEstateRepository { get; private set; }
        public UserRepository UserRepository { get; private set; }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
