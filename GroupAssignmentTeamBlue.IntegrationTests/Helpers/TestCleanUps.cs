using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    internal class TestCleanUps<TEntity> : IDisposable 
        where TEntity : class
    {
        private UnitOfWork db { get; set; }
        private Stack<TEntity> trackedEntities = new Stack<TEntity>();

        public TestCleanUps(AdvertContext context)
        {
            db = new UnitOfWork(context);
        }

        /// <summary>
        /// Pushes the given entity into a the trackedEntities stack
        /// </summary>
        /// <param name="entity"></param>
        public void TrackEntity(TEntity entity)
        {
            trackedEntities.Push(entity);
        }

        /// <summary>
        /// Removes the tracked entites from the database
        /// </summary>
        public void Dispose()
        {
            // TODO: Remove Test Entities from Db
            throw new NotImplementedException();
        }
    }
}
