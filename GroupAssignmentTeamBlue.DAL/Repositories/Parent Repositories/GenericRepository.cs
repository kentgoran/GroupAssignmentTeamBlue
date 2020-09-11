using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.DAL.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly Context.AdvertContext context;

        public GenericRepository(Context.AdvertContext context)
        {
            this.context = context;
        }
        public virtual void Add(TEntity entityToAdd)
        {
            context.Set<TEntity>().Add(entityToAdd);
        }

        public virtual void Remove(int Id)
        {          
            if (EntityExists(Id))
            {
                var entityToRemove = Get(Id);
                context.Set<TEntity>().Remove(entityToRemove);
            }

            //TODO: vad gör vi om entityn inte hittas?
        }

        public virtual TEntity Get(int Id)
        {
            return context.Set<TEntity>().Find(Id);
        }
        public virtual ICollection<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public virtual void Update(TEntity entityToUpdate)
        {
            context.Set<TEntity>().Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
        public virtual bool EntityExists(int Id)
        {
            return context.Set<TEntity>().Find(Id) != null;
        }
    }
}
