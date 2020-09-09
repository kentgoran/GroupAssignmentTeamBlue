using GroupAssignmentTeamBlue.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public class ContactRepository : GenericRepository<ContactRepository>
    {
        public ContactRepository(AdvertContext context) : base(context)
        {
        }
    }
}
