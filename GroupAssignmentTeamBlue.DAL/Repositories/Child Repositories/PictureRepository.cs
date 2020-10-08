using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupAssignmentTeamBlue.DAL.Repositories.Child_Repositories
{
    public class PictureRepository : GenericRepository<Picture>
    {
        public PictureRepository(AdvertContext context) : base(context)
        {
        }

        public IEnumerable<Picture> GetAllPicturesForRealEstate(int realEstateId)
        {
            return context.Pictures.Where(p => p.RealEstateId == realEstateId).ToList();
        }
    }
}
