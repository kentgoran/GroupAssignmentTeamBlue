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
    public class RealEstateRepository : GenericRepository<RealEstate>
    {
        public RealEstateRepository(AdvertContext context) : base(context)
        {
        }

        /// <summary>
        /// Skips and takes a number of realEstates, search by city, ordered by date of creation, descending
        /// </summary>
        /// <param name="skip">amount to skip</param>
        /// <param name="take">amount to take</param>
        /// <param name="city">filter by city</param>
        /// <returns>a list of RealEstates</returns>
        public ICollection<RealEstate> SkipAndTakeRealEstatesByCity(int skip, int take, string city)
        {
            return context.RealEstates
                .OrderByDescending(r => r.DateOfAdvertCreation)
                .Where(re => re.City.ToLower().Contains(city))
                .Skip(skip).Take(take).ToList();
        }


        /// <summary>
        /// Gets a realEstate, including its comments, pictures and user
        /// </summary>
        /// <param name="Id">Id of given realEstate</param>
        /// <returns>a RealEstate</returns>
        public RealEstate GetWithIncludes(int Id)
        {
            return context.RealEstates.Where(r => r.Id == Id)
                .Include(r => r.Pictures)
                .Include(r => r.User)
                .Include(r => r.Comments)
                .ThenInclude(c => c.User).FirstOrDefault();
        }
        
        public int GetRealEstateCount()
        {
            return context.RealEstates.Count();
        }
        public int GetRealEstateCountCity(string city)
        {
            return context.RealEstates.Where(r => r.City.ToLower().Contains(city)).Count();
        }
    }
}
