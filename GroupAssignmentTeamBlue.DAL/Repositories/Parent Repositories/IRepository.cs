using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entityToAdd);
        TEntity Get(int Id);
        void Update(TEntity entityToUpdate);
        void Remove(TEntity Id);
        bool EntityExists(int id);
    }
}
