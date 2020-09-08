using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly Context.AdvertContext context;

        public GenericRepository(Context.AdvertContext context)
        {
            this.context = context;
        }
        public void Add(TEntity entityToAdd)
        {
            context.Set<TEntity>().Add(entityToAdd);
        }

        public void Remove(Guid Id)
        {
            var entityToRemove = Get(Id);

            if (entityToRemove != null)
            {
                context.Set<TEntity>().Remove(entityToRemove);
            }

            //TODO: vad gör vi om entityn är null?
        }

        public TEntity Get(Guid Id)
        {
            return context.Set<TEntity>().Find(Id);
        }

        public void Update(TEntity entityToUpdate)
        {
            context.Set<TEntity>().Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
