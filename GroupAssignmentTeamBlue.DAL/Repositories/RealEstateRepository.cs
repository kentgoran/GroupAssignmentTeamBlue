using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public class RealEstateRepository : GenericRepository<RealEstate>
    {
        public RealEstateRepository(AdvertContext context) : base(context)
        {
        }
    }
}
