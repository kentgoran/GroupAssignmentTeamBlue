using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupAssignmentTeamBlue.UnitTests.Helpers
{
    internal class MockedDbSet<TEntity> : Mock<DbSet<TEntity>>
        where TEntity : class
    {

        public MockedDbSet(IEnumerable<TEntity> setData)
        {
            var queriableData = setData.AsQueryable();

            this.As<IQueryable<TEntity>>().Setup(ds => ds.Provider).Returns(queriableData.Provider);
            this.As<IQueryable<TEntity>>().Setup(ds => ds.Expression).Returns(queriableData.Expression);
            this.As<IQueryable<TEntity>>().Setup(ds => ds.ElementType).Returns(queriableData.ElementType);
            this.As<IQueryable<TEntity>>().Setup(ds => ds.GetEnumerator()).Returns(queriableData.GetEnumerator());
        }
    }
}
